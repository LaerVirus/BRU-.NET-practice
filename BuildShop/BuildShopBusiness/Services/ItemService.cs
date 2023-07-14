using BuildShopPresentationLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildShopBusinessAccessLayer
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepository;

        public DeliveryService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public async Task<IEnumerable<Item>> GetItemsAsync()
        {
            return await _itemRepository.GetAllAsync();
        }

        // other methods for CRUD operations
    }
}
