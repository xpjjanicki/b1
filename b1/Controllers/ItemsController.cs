using b1.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace b1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IItemRepository _itemRepository;

        public ItemsController(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetItemsList()
        {
            var productDetailsList = await _itemRepository.GetAllItems();
            if (productDetailsList == null)
            {
                return NotFound();
            }
            return Ok(productDetailsList);
        }
    }
}
