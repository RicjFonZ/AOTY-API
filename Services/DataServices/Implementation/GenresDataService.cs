using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DataAccess.Repositories;
using DataAccess.Repositories.Interfaces;
using Models;
using Models.DTOs;
using Models.Enums;
using Models.Models;

namespace Services.DataServices.Implementation
{
    public class GenresDataService : BaseDataService, IGenresDataService
    {

        #region _CTOR_

        public GenresDataService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Adds the new genre.
        /// </summary>
        /// <param name="newGenre">The new genre.</param>
        /// <returns></returns>
        public async Task<DataServiceResponse<int>> AddNewGenre(GenresDto newGenre)
        {
            var response = new DataServiceResponse<int>
            {
                Status = DataServiceResponseStatusEnum.Added,
                Message = "Genre successfully added."
            };

            var existingGenre = await UnitOfWork.Repository<Genres>()!.GetWhereAsync(x => x.GenreCode == newGenre.GenreCode);
            var firstExistingGenre = existingGenre.FirstOrDefault();

            if (firstExistingGenre != null)
            {
                response.Status = DataServiceResponseStatusEnum.AlreadyExists;
                response.Message = "Genre with this GenreCode already exists.";
                response.Data = firstExistingGenre.Id;
            }
            else
            {
                var genresEntity = Mapper.Map<Genres>(newGenre);
                UnitOfWork.Repository<Genres>()!.Add(genresEntity);
                await UnitOfWork.SaveAsync();
                response.Data = genresEntity.Id;
            }

            return response;
        }

        public Task<DataServiceResponse<bool>> UpdateGenre(GenresDto updatedGenre)
        {
            throw new NotImplementedException();
        }

        public Task<DataServiceResponse<bool>> DeleteGenre(int genreId)
        {
            throw new NotImplementedException();
        }

        public Task<DataServiceResponse<List<GenresDto>>> GetAllGenres()
        {
            throw new NotImplementedException();
        }

        public Task<DataServiceResponse<GenresDto>> GetGenreById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<DataServiceResponse<GenresDto>> GetGenreByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<DataServiceResponse<GenresDto>> GetGenreByGenreCode(string genreCode)
        {
            throw new NotImplementedException();
        }

        #endregion


    }
}
