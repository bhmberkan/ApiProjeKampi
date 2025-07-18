using ApiProjeKampi.WebApi.Context;
using ApiProjeKampi.WebApi.Dtos.ReservationDtos;
using ApiProjeKampi.WebApi.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private readonly ApiContext _context;
        private readonly IMapper _mapper;
        public ReservationsController(ApiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ReservationsList()
        {
            var values = _context.Reservations.ToList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateReservations(CreateReservationDto createReservationsDto)
        {
            // _context.Categories.Add(Reservations);
            // _context.SaveChanges();
            var value = _mapper.Map<Reservation>(createReservationsDto);
            _context.Reservations.Add(value);
            _context.SaveChanges();
            return Ok("Rezervasyon Ekleme işlemi başarılı");

        }

        [HttpDelete]
        public IActionResult DeleteReservations(int id)
        {
            var value = _context.Reservations.Find(id);
            _context.Reservations.Remove(value);
            _context.SaveChanges();
            return Ok("Rezervasyon Silme İşlemi başarılı");
        }

        [HttpGet("GetReservations")] // iki tane get kullandık isimlendirme yapmalıyız
        public IActionResult GetReservations(int id)
        {
            var value = _context.Reservations.Find(id);
            return Ok(_mapper.Map<Reservation>(value));


        }

        [HttpPut]
        public IActionResult UpdateReservations(UpdateReservationDto updateReservationsDto)
        {
            var value = _mapper.Map<Reservation>(updateReservationsDto);
            _context.Reservations.Update(value);
            _context.SaveChanges();

            return Ok("Rezervasyon Güncelleme işlemi başarılı");
        }
    }
}
