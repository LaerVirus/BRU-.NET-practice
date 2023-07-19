using BuildShopDataAccessLayer;
using BuildShopDataAccessLayer.Repositories;
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

        public ItemService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public async Task<IEnumerable<Item>> GetAll()
        {
            return await _itemRepository.GetAll();
        }

        // other methods for CRUD operations
    }
}
