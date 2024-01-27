using RestaurantSystem.Models;
using RestaurantSystem.Repository;

namespace RestaurantSystem.Services
{
    public class EmployeeService
    {
        IMemoryRepository<Employee> _repository;
        public EmployeeService(IMemoryRepository<Employee> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Employee> GetAll()
        {
            return _repository.GetAll();
        }

        public Employee GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public string Create(Employee item)
        {
            if (string.IsNullOrEmpty(item.FirstName))
            {
                return "The name cannot be empty";
            }
            else
            {
                _repository.Create(item);
                return $"Created new item with this ID: {item.Id}";
            }
        }

        public string Update(Guid id, Employee item)
        {
            var _item = _repository.GetById(id);
            if (_item is null)
            {
                return "Item not found";
            }
            _repository.Update(_item);
            return "Item updated";
        }

        public string Delete(Guid id)
        {
            var _item = _repository.GetById(id);
            if (_item is null)
            {
                return "Item not found";
            }
            _repository.Delete(id);

            return "Item deleted";
        }
    }
}

