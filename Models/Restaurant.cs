using System.Text.Json.Serialization;

namespace RestaurantSystem.Models
{
    public class Restaurant
    {
        public Restaurant()
        {
            Branchs = new();
        }
        public string Name { get; set; }
        public List<Branch> Branchs { get; set; }
        public string Address { get; set; }

    }
}
