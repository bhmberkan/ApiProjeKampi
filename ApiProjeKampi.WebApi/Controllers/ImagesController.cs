using ApiProjeKampi.WebApi.Context;
using ApiProjeKampi.WebApi.Dtos.ImagesDto;
using ApiProjeKampi.WebApi.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly ApiContext _context;
        private readonly IMapper _mapper;
        public ImagesController(ApiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ImagesList()
        {
            var values = _context.Images.ToList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateImages(CreateImagesDto createImagesDto)
        {
            // _context.Categories.Add(Images);
            // _context.SaveChanges();
            var value = _mapper.Map<Image>(createImagesDto);
            _context.Images.Add(value);
            _context.SaveChanges();
            return Ok("Resim Ekleme işlemi başarılı");

        }

        [HttpDelete]
        public IActionResult DeleteImages(int id)
        {
            var value = _context.Images.Find(id);
            _context.Images.Remove(value);
            _context.SaveChanges();
            return Ok("Resim Silme İşlemi başarılı");
        }

        [HttpGet("GetImages")] 
        public IActionResult GetImages(int id)
        {
            var value = _context.Images.Find(id);
            return Ok(_mapper.Map<Image>(value));


        }

        [HttpPut]
        public IActionResult UpdateImages(UpdateImagesDto updateImagesDto)
        {
            var value = _mapper.Map<Image>(updateImagesDto);
            _context.Images.Update(value);
            _context.SaveChanges();

            return Ok("Resim Güncelleme işlemi başarılı");
        }

    }
}
