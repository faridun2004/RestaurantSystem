using Microsoft.AspNetCore.Mvc;
using RestaurantSystem.Models;

namespace RestaurantSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestaurantController: ControllerBase
    {
        private readonly ILogger<RestaurantController> _logger;

        public RestaurantController(ILogger<RestaurantController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetBonk")]
        public Restaurant Get()
        {
            var restaurant = new Restaurant();
            restaurant.Name = "Faridun_Live_Restaurant";
            restaurant.Address = "Khujand_I_Somoni";
            var branch1 = new Branch();
            branch1.Address = "Station";
            var branch2 = new Branch();
            branch2.Address = "Guliston, Glavnoy";
            restaurant.Branchs.Add(branch1);
            restaurant.Branchs.Add(branch2);

            return restaurant;
        }
    }
}
