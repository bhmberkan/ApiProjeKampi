using ApiProjeKampi.WebApi.Context;
using ApiProjeKampi.WebApi.Dtos.ContactDtos;
using ApiProjeKampi.WebApi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly ApiContext _Context;

        public ContactsController(ApiContext context)
        {
            _Context = context;
        }

        [HttpGet]
        public IActionResult ContactList()
        {
            var values = _Context.Contacts.ToList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateContact(CreateContactDto createContactDto)
        {
            Contact contact = new Contact();
            contact.Email = createContactDto.Email;
            contact.Adress = createContactDto.Adress;
            contact.Phone = createContactDto.Phone;
            contact.MapLocation = createContactDto.MapLocation;
            contact.OpenHours = createContactDto.OpenHours;
            _Context.Contacts.Add(contact);
            _Context.SaveChanges();
            return Ok("Ekleme İşlemi başarılı"); 
        }

        [HttpDelete]
        public IActionResult DeleteContact(int id)
        {
            var value = _Context.Contacts.Find(id);
            _Context.Contacts.Remove(value);
            _Context.SaveChanges();
            return Ok("Silme işlemi başarılı");
        }

        [HttpGet("GetContact")]
        public IActionResult GetContact(int id)
        {
            var value = _Context.Contacts.Find(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateContact(UpdateContactDto updateContactDto)
        {
            Contact contact= new Contact();
            contact.Email = updateContactDto.Email;
            contact.Adress= updateContactDto.Adress;
            contact.Phone = updateContactDto.Phone;
            contact.ContactId = updateContactDto.ContactId;
            contact.MapLocation= updateContactDto.MapLocation;
            contact.OpenHours= updateContactDto.OpenHours;
            _Context.Contacts.Update(contact);
            _Context.SaveChanges();
            return Ok("Güncelleme işlemi başarılı");
        }
    }
}
