using Microsoft.AspNetCore.Mvc;
using RestaurantSystem.Models;
using RestaurantSystem.Services;

namespace RestaurantSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        readonly IEmployeeService _service;
        public EmployeeController(IEmployeeService service)
        {
            _service = service;
        }

        [HttpGet("AllItems")]
        public IEnumerable<Employee> Get()
        {
            return _service.GetAll();
        }
        [HttpGet("GetItemById")]
        public Employee Get(Guid id)
        {
            return _service.GetById(id);
        }

        [HttpPost("Create")]
        public string Post([FromBody] Employee item)
        {
            return _service.Create(item);
        }

        [HttpPut("Update")]
        public string Put([FromQuery] Guid id, [FromBody] Employee item)
        {
            return _service.Update(id, item);
        }

        [HttpDelete("Delete")]
        public string Delete([FromQuery] Guid id)
        {
            return _service.Delete(id);
        }

    }
}
