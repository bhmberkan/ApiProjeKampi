using ApiProjeKampi.WebApi.Context;
using ApiProjeKampi.WebApi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiProjeKampi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChefController : ControllerBase
    {
        private readonly ApiContext _context;

        public ChefController(ApiContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetChefList()
        {
            var value = _context.Chefs.ToList();
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateChef(Chef chef)
        {
           _context.Chefs.Add(chef);
            _context.SaveChanges();
            return Ok("Chef Ekleme işlemi başarılı");
        }

        [HttpDelete]
        public IActionResult DeleteChef(int id)
        {
            var value = _context.Chefs.Find(id);
            _context.Chefs.Remove(value);
            _context.SaveChanges();
            return Ok("Şef Silme işlemi başarılı");

        }


        [HttpGet("GetChefId")]
        public IActionResult GetChefId(int id)
        {
           /* var value = _context.Chefs.Find(id);
            return  Ok(value);*/

            return Ok(_context.Chefs.Find(id));
        }

        [HttpPut]
        public IActionResult UpdateChef(Chef chef)
        {
            _context.Chefs.Update(chef);
            _context.SaveChanges();
            return Ok("Chef Güncelleme işlemi başarılı");
        }

    }
}
