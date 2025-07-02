namespace ApiProjeKampi.WebUI.Dtos.FeatureDtos
{
    public class UpdateFeatureDto
    {
        public int FeatureId { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public string VideoUrl { get; set; }
        public string ImageUrl { get; set; }
    }
}
