using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Services.DataServices;

namespace Services.Services.Implementation
{
    /// <summary>
    /// UpdateService
    /// </summary>
    /// <seealso cref="IUpdateService" />
    public class UpdateService : IUpdateService
    {
        #region Private Fields

        private readonly IGenresDataService _genresDataService;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateService"/> class.
        /// </summary>
        /// <param name="genresDataService">The genres data service.</param>
        public UpdateService(IGenresDataService genresDataService)
        {
            _genresDataService = genresDataService;
        }

        #endregion

        #region Public Methods

        #endregion

        public Task<DataServiceResponse<bool>> UpdateGenres()
        {
            throw new NotImplementedException();
        }
    }
}
