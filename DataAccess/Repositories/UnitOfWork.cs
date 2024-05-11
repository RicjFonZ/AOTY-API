using DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore;
using Models.Models;

namespace DataAccess.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Properties / Attributtes

        private readonly ApplicationDbContext _context;
        private readonly Dictionary<Type, object?> _repositories = new();

        #endregion Properties / Attributtes

        #region _CTOR_

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitOfWork" /> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        #endregion _CTOR_

        #region Public Methods

        /// <summary>
        /// Repositories this instance.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public IRepository<T>? Repository<T>() where T : class
        {
            if (_repositories.ContainsKey(typeof(T)))
            {
                return _repositories[typeof(T)] as IRepository<T>;
            }

            IRepository<T> repo = new Repository<T>(_context);
            _repositories.Add(typeof(T), repo);
            return repo;
        }

        /// <summary>
        /// Saves the asynchronous.
        /// </summary>
        public async Task SaveAsync()
        {
            var entries = _context.ChangeTracker.Entries();

            foreach (var entry in entries)
            {
                if (entry.Entity is BaseEntity trackable)
                {
                    switch (entry.State)
                    {
                        case EntityState.Modified:
                            // Set the updated date to "now"
                            trackable.EditedAt = DateTime.UtcNow;

                            // Leave the created date as it is
                            entry.Property("CreatedAt").IsModified = false;
                            break;

                        case EntityState.Added:
                            // Set the created date to "now"
                            trackable.CreatedAt = DateTime.UtcNow;
                            break;
                    }
                }
            }

            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Begins the transaction asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<IDbContextTransaction> BeginTransactionAsync()
        {
            return await _context.Database.BeginTransactionAsync();
        }

        #endregion Public Methods
    }
}
