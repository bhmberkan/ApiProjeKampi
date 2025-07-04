using ApiProjeKampi.WebApi.Context;
using ApiProjeKampi.WebApi.Dtos.AboutDtos;
using ApiProjeKampi.WebApi.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ApiContext _context;
        public AboutsController(IMapper mapper, ApiContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        [HttpGet]
        public IActionResult AboutList()
        {
            var value = _context.abouts.ToList();
            return Ok(_mapper.Map<List<ResultAboutDto>>(value));

        }

        [HttpPost]
        public IActionResult CreateAbout(CreateAboutDto createAboutDto)
        {
            var value = _mapper.Map<About>(createAboutDto);
            _context.abouts.Add(value);
            _context.SaveChanges();
            return Ok("Ekleme işlemi başarılı");
        }


        [HttpDelete]
        public IActionResult DeleteAbout(int id)
        {
            var value = _context.abouts.Find(id);
            _context.abouts.Remove(value);
            _context.SaveChanges();
            return Ok("Hakkimda silme işlemi başarılı");
        }

        [HttpGet("GetAbout")]
        public IActionResult GetAbout(int id)
        {
            var value = _context.abouts.Find(id);
            return Ok(_mapper.Map<GetAboutByIdDto>(value));

        }

        [HttpPut]
        public IActionResult UpdateAbout(UpdateAboutDto updateAboutDto)
        {
            var value = _mapper.Map<About>(updateAboutDto);
            _context.abouts.Update(value);
            _context.SaveChanges();
            return Ok("Hakkimda Güncelleme işlemi başarılı");
        }

    }
}
