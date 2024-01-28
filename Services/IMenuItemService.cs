using RestaurantSystem.Models;

namespace RestaurantSystem.Services
{
    public interface IMenuItemService
    {
        IEnumerable<MenuItem> GetAll();
        MenuItem GetById(Guid id);
        string Create(MenuItem menuItem);
        string Update(Guid id, MenuItem item);
        string Delete(Guid id);
    }
}
