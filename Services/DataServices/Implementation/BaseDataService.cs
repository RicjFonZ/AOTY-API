using AutoMapper;
using DataAccess.Repositories.Interfaces;

namespace Services.DataServices.Implementation
{
    /// <summary>
    /// BaseDataService
    /// </summary>
    public abstract class BaseDataService
    {
        #region Properties / Attributtes

        protected readonly IUnitOfWork UnitOfWork;
        protected readonly IMapper Mapper;

        #endregion Properties / Attributtes

        #region _CTOR_

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseDataService"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unit of work.</param>
        /// <param name="mapper">The mapper.</param>
        protected BaseDataService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            UnitOfWork = unitOfWork;
            Mapper = mapper;
        }

        #endregion _CTOR_
    }
}