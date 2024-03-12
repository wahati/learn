using System.ComponentModel.DataAnnotations;

namespace webapi.Models
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public required string Name { get; set; }
        [Required]
        public required string Description { get; set; }
        [Required]
        public required string IconUrl { get; set; }
    }
}
