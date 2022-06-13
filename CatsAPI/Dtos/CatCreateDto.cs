using System.ComponentModel.DataAnnotations;

namespace CatsAPI.Dtos
{
    public class CatCreateDto
    {

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
        public string GroomingTips { get; set; }
    }
}