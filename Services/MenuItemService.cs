using RestaurantSystem.Models;
using RestaurantSystem.Repository;

namespace RestaurantSystem.Services
{
    public class MenuItemService : IMenuItemService
    {
        IMemoryRepository<MenuItem> _repository;
        public MenuItemService(IMemoryRepository<MenuItem> repository)
        {
            _repository = repository;
        }

        public IEnumerable<MenuItem> GetAll()
        {
            return _repository.GetAll();
        }

        public MenuItem GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public string Create(MenuItem item)
        {
            if (string.IsNullOrEmpty(item.Name))
            {
                return "The name cannot be empty";
            }
            else
            {
                _repository.Create(item);
                return $"Created new item with this ID: {item.Id}";
            }
        }

        public string Update(Guid id, MenuItem item)
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

