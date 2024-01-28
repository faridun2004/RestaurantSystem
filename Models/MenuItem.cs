namespace RestaurantSystem.Models
{
    public class MenuItem: BaseEntity
    {
        public required string Name { get; set; }
        public decimal Price { get; set; }
    }
}
