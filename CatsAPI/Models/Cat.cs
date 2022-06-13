using System.ComponentModel.DataAnnotations;

namespace CatsAPI.Models
{
    public class Cat
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Species { get; set; }

        [Required]
        public decimal AverageLifespan { get; set; }

        [Required]
        public decimal AverageLength { get; set; }

        [Required]
        public decimal AverageWeight { get; set; }

        [Required]
        public decimal AverageHeight { get; set; }

        [Required]
        public string PlaceOfOrigin { get; set; }

        public string? SampleImageUrl { get; set; }

        [Required]
        public IEnumerable<Condition> Conditions { get; set; }

        [Required]
        public string GroomingTips { get; set; }

    }
}