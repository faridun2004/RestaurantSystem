namespace RestaurantSystem.Models
{
    public class Branch :BaseEntity
    {
        public Branch()
        {
            Employees = new();
            Customers = new();
        }

        public string Address { get; set; }

        public List<Employee> Employees { get; set; }

        public List<Customer> Customers { get; set; }
    }
}

