using ApiProjeKampi.WebApi.Context;
using ApiProjeKampi.WebApi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class YummyEventController : ControllerBase
    {
        private readonly ApiContext _context;

        public YummyEventController(ApiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult YummyEventList()
        {
            var values = _context.yumyEvents.ToList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateYummyEvent(YumyEvent YummyEvent)
        {
            _context.yumyEvents.Add(YummyEvent);
            _context.SaveChanges();
            return Ok("Etkinlik Ekleme işlemi başarılı");

        }

        [HttpDelete]
        public IActionResult DeleteYummyEvent(int id)
        {
            var value = _context.yumyEvents.Find(id);
            _context.yumyEvents.Remove(value);
            _context.SaveChanges();
            return Ok("Etkinlik Silme İşlemi başarılı");
        }

        [HttpGet("GetYummyEvent")] 
        public IActionResult GetYummyEvent(int id)
        {
            var value = _context.yumyEvents.Find(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateYummyEvent(YumyEvent YummyEvent)
        {
            _context.yumyEvents.Update(YummyEvent);
            _context.SaveChanges();
            return Ok("Etkinlik Güncelleme işlemi başarılı");
        }
    }
}
