using b1.Shared;

namespace b1.Client.Services.Interfaces
{
    public interface IItemService
    {
        Task<List<Item>> GetAllItems();
    }
}
