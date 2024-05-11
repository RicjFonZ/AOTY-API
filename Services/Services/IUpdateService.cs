using Models;

namespace Services.Services
{
    /// <summary>
    /// UpdateService
    /// </summary>
    public interface IUpdateService
    {
        /// <summary>
        /// Updates the genres.
        /// </summary>
        /// <returns></returns>
        Task<DataServiceResponse<bool>> UpdateGenres();
    }
}