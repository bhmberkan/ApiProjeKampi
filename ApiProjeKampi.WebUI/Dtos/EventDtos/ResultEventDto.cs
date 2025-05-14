namespace ApiProjeKampi.WebUI.Dtos.EventDtos
{
    public class ResultEventDto
    {
        public int YumyEventId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }
        public Decimal Price { get; set; }
    }
}
