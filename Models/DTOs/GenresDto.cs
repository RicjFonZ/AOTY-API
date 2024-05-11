using Models.Models;

namespace Models.DTOs
{
    /// <summary>
    /// GenresDto
    /// </summary>
    /// <seealso />
    public class GenresDto : BaseEntity
    {
        public string GenreName { get; set; }
        public string GenreCode { get; set; }
    }
}