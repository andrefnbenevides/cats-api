namespace CatsAPI.Dtos
{
    public class CatReadDto
    {
        public int Id { get; set; }

        public string Species { get; set; }

        public decimal AverageLifespan { get; set; }

        public decimal AverageLength { get; set; }

        public decimal AverageWeight { get; set; }

        public decimal AverageHeight { get; set; }

        public string PlaceOfOrigin { get; set; }

        public string? SampleImageUrl { get; set; }

        public string GroomingTips { get; set; }
    }
}