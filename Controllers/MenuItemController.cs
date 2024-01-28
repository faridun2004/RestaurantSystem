using Microsoft.AspNetCore.Mvc;
using RestaurantSystem.Models;
using RestaurantSystem.Services;

namespace RestaurantSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MenuItemController
    {
        readonly IMenuItemService _service;
        public MenuItemController(IMenuItemService service)
        {
            _service = service;
        }

        [HttpGet("AllItems")]
        public IEnumerable<MenuItem> Get()
        {
            return _service.GetAll();
        }

        [HttpGet("GetItemById")]
        public MenuItem Get(Guid id)
        {
            return _service.GetById(id);
        }

        [HttpPost("Create")]
        public string Post([FromBody] MenuItem item)
        {
            return _service.Create(item);
        }

        [HttpPut("Update")]
        public string Put([FromQuery] Guid id, [FromBody] MenuItem item)
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
