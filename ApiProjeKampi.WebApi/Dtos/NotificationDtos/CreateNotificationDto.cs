namespace ApiProjeKampi.WebApi.Dtos.NotificationDtos
{
    public class CreateNotificationDto
    {

        public string Description { get; set; }
        public string IconUrl { get; set; }
        public DateTime NotificationDate { get; set; }
        public bool IsRead { get; set; }
    }
}
