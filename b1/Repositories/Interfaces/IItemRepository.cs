using b1.Shared;

namespace b1.Repositories.Interfaces
{
    public interface IItemRepository
    {
        Task<List<Item>?> GetAllItems();
    }
}
