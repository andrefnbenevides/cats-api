using System.ComponentModel.DataAnnotations;

namespace CatsAPI.Models
{
    public class Condition
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
    }
}