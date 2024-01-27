namespace RestaurantSystem.Models
{
    public class MenuItem: BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
