using Models;
using Models.DTOs;

namespace Services.DataServices
{
    /// <summary>
    /// IGenresDataService
    /// </summary>
    public interface IGenresDataService
    {
        /// <summary>
        /// Adds the new genre.
        /// </summary>
        /// <param name="newGenre">The new genre.</param>
        /// <returns></returns>
        Task<DataServiceResponse<int>> AddNewGenre(GenresDto newGenre);

        /// <summary>
        /// Updates the genre.
        /// </summary>
        /// <param name="updatedGenre">The updated genre.</param>
        /// <returns></returns>
        Task<DataServiceResponse<bool>> UpdateGenre(GenresDto updatedGenre);

        /// <summary>
        /// Deletes the genre.
        /// </summary>
        /// <param name="genreId">The genre identifier.</param>
        /// <returns></returns>
        Task<DataServiceResponse<bool>> DeleteGenre(int genreId);

        /// <summary>
        /// Gets all genres.
        /// </summary>
        /// <returns></returns>
        Task<DataServiceResponse<List<GenresDto>>> GetAllGenres();

        /// <summary>
        /// Gets the genre by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task<DataServiceResponse<GenresDto>> GetGenreById(int id);

        /// <summary>
        /// Gets the name of the genre by.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        Task<DataServiceResponse<GenresDto>> GetGenreByName(string name);

        /// <summary>
        /// Gets the genre by genre code.
        /// </summary>
        /// <param name="genreCode">The genre code.</param>
        /// <returns></returns>
        Task<DataServiceResponse<GenresDto>> GetGenreByGenreCode(string genreCode);
    }
}