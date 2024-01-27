namespace RestaurantSystem.Models
{
    public class BaseEntity
    {
        public Guid Id { get; }

        public BaseEntity()
        {
            Id = Guid.NewGuid();
        }

        public override string ToString()
        {
            return $"Id:{Id} ({GetType().Name})";
        }
    }
}
