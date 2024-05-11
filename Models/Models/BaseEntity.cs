using System.ComponentModel.DataAnnotations;

namespace Models.Models
{
    /// <summary>
    /// BaseEntity
    /// </summary>
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        public DateTime? EditedAt { get; set; }
    }
}