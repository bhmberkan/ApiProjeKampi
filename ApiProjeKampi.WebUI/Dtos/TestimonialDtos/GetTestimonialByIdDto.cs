namespace ApiProjeKampi.WebUI.Dtos.TestimonialDtos
{
    public class GetTestimonialByIdDto
    {
        public int testimonialId { get; set; }
        public string nameSurname { get; set; }
        public string title { get; set; }
        public string comment { get; set; }
        public string imageUrl { get; set; }
    }
}
