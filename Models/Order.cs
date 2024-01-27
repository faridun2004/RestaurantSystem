namespace RestaurantSystem.Models
{
    public class Order: BaseEntity
    {
        public List<MenuItem> Items { get; set; }
        public decimal TotalPrice => Items.Sum(item => item.Price);
    }
}
