using RestaurantSystem.Models;

namespace RestaurantSystem.Services
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAll();
        Employee GetById(Guid id);
        string Create(Employee employee);
        string Update(Guid id, Employee item);
        string Delete(Guid id);
    }
}
