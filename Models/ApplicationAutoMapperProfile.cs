using AutoMapper;
using Models.DTOs;
using Models.Models;

namespace Models
{
    /// <summary>
    /// AutoMapperExtensions
    /// </summary>
    public static class AutoMapperExtensions
    {
        /// <summary>
        /// Creates the bidirectional map.
        /// </summary>
        /// <typeparam name="T1">The type of the 1.</typeparam>
        /// <typeparam name="T2">The type of the 2.</typeparam>
        /// <param name="profile">The profile.</param>
        public static void CreateBidirectionalMap<T1, T2>(this Profile profile)
        {
            profile.CreateMap<T1, T2>();
            profile.CreateMap<T2, T1>();
        }
    }

    /// <summary>
    /// ApplicationAutoMapperProfile
    /// </summary>
    /// <seealso cref="AutoMapper.Profile" />
    public class ApplicationAutoMapperProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationAutoMapperProfile"/> class.
        /// </summary>
        public ApplicationAutoMapperProfile()
        {
            this.CreateBidirectionalMap<Genres, GenresDto>();
        }
    }
}