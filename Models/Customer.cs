namespace RestaurantSystem.Models
{
    public class Customer: Person
    {
        public CustomerStatus State { get; set; }
       
    }
    public enum CustomerStatus
    {
        Orginization,
        Persion
    }
}
