using b1.Client.Services.Interfaces;
using b1.Shared;
using System.Text.Json;

namespace b1.Client.Services
{
    public class ItemService : IItemService
    {
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions _serializerOptions;

        public ItemService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _serializerOptions = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
        }
        public async Task<List<Item>?> GetAllItems()
        {

            var response = await _httpClient.GetStreamAsync("api/items");
            var items = await JsonSerializer.DeserializeAsync<List<Item>>(response, _serializerOptions);

            return items;
        }
    }
}
