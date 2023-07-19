using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildShopDataAccessLayer;
using BuildShopDataAccessLayer.Repositories;

namespace BuildShopBusinessAccessLayer
{

    public class OrderedItemService : IOrderedItemService
    {
        private readonly IOrderedItemRepository _orderedItemRepository;

        public OrderedItemService(IOrderedItemRepository orderedItemRepository)
        {
            _orderedItemRepository = orderedItemRepository;
        }

        public async Task<IEnumerable<OrderedItem>> GetAll()
        {
            return await _orderedItemRepository.GetAll();
        }

        // other methods for CRUD operations
    }
}
