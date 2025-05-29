using ApiProjeKampi.WebApi.Context;
using ApiProjeKampi.WebApi.Dtos.NotificationDtos;
using ApiProjeKampi.WebApi.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ApiContext _context;

        public NotificationsController(IMapper mapper, ApiContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        [HttpGet]
        public IActionResult NotificationList()
        {
            var values = _context.notifications.ToList();
            return Ok(_mapper.Map<List<ResultNotificationDto>>(values)); // auto mapleme işlemi
            // mapper maple liste halinde Notificationsdto'muzu nerden gelen değerle ? valuesten gelen değerle maplenecek


        }

        [HttpPost]
        public IActionResult CreateNotification(CreateNotificationDto createNotificationDto)
        {
            var value = _mapper.Map<Notification>(createNotificationDto);
            _context.notifications.Add(value);
            _context.SaveChanges();
            return Ok("Ekleme işlemi Başarılı");
        }

        [HttpDelete]
        public IActionResult DeleteNotification(int id)
        {
            var value = _context.notifications.Find(id);
            _context.notifications.Remove(value);
            _context.SaveChanges();
            return Ok("Silme işlemi Başarılı");
        }

        [HttpGet("GetNotification")]
        public IActionResult GetNotification(int id)
        {
            var value = _context.notifications.Find(id);
            return Ok(_mapper.Map<GetNotificationByIdDto>(value)); // tek değer dondüreceği için list içine almadım
        }

        [HttpPut]
        public IActionResult UpdateNotification(UpdateNotificationDto updateNotificationDto)
        {
            var value = _mapper.Map<Notification>(updateNotificationDto);
            _context.notifications.Update(value);
            _context.SaveChanges();
            return Ok("Güncelleme işlemi başarılı");
        }


        [HttpGet("NotificationListByIsReadFalse")]
        public IActionResult NotificationListByIsReadFalse()
        {
            var value = _context.notifications.Where(x => x.IsRead == false).ToList();
            return Ok(value);
        }
    }
}
