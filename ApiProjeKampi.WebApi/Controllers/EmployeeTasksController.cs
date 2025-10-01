using ApiProjeKampi.WebApi.Context;
using ApiProjeKampi.WebApi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeTasksController : ControllerBase
    {
        private readonly ApiContext _context;

        public EmployeeTasksController(ApiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult EmployeeTaskList()
        {
            var values = _context.employeeTasks.ToList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateEmployeeTask(EmployeeTask employeeTask)
        {
            _context.employeeTasks.Add(employeeTask);
            _context.SaveChanges();
            return Ok(" Ekleme işlemi başarılı");

        }

        [HttpDelete]
        public IActionResult DeleteEmployeeTask(int id)
        {
            var value = _context.employeeTasks.Find(id);
            _context.employeeTasks.Remove(value);
            _context.SaveChanges();
            return Ok(" Silme İşlemi başarılı");
        }

        [HttpGet("GetEmployeeTask")] // iki tane get kullandık isimlendirme yapmalıyız
        public IActionResult GetEmployeeTask(int id)
        {
            var value = _context.employeeTasks.Find(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateEmployeeTask(EmployeeTask employeeTask)
        {
            _context.employeeTasks.Update(employeeTask);
            _context.SaveChanges();
            return Ok(" Güncelleme işlemi başarılı");
        }
    }
}
