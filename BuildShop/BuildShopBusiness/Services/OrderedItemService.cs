using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildShopPresentationLayer;

namespace BuildShopBusinessAccessLayer
{

    public class OrderedItemService : IOrderedItemService
    {
        private readonly IOrderedItemRepository _orderedItemRepository;

        public OrderedItemService(IOrderedItemRepository orderedItemRepository)
        {
            _orderedItemRepository = orderedItemRepository;
        }

        public async Task<IEnumerable<OrderedItem>> GetOrderedItemsAsync()
        {
            return await _orderedItemRepository.GetAllAsync();
        }

        // other methods for CRUD operations
    }
}
