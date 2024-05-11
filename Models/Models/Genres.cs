using System.ComponentModel.DataAnnotations;

namespace Models.Models
{
    public class Genres : BaseEntity
    {
        [Required]
        public string GenreName { get; set; }

        [Required]
        public string GenreCode { get; set; }
    }
}