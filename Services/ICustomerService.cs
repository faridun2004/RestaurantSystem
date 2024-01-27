using RestaurantSystem.Models;

namespace RestaurantSystem.Services
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetAll();

        /// <summary>
        /// This is for getting item by Id
        /// </summary>
        /// <param name="id">Id of item</param>
        /// <returns>retruns item if found otherwase null</returns>
        Customer GetById(Guid id);
        string Create(Customer customer);
        string Update(Guid id, Customer item);
        string Delete(Guid id);
    }
}
