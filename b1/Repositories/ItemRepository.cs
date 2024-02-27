using b1.Repositories.Interfaces;
using b1.Shared;

namespace b1.Repositories
{
    public class ItemRepository : IItemRepository
    {
        public async Task<List<Item>?> GetAllItems()
        {
            List<Item> items = [new Item() { Id = 1, Name = "name" }];

            return items;
        }
    }
}
