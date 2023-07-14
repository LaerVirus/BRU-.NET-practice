using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildShopPresentationLayer;

namespace BuildShopBusinessAccessLayer
{
    public class ItemsCategoryService : IItemsCategoryService
    {
        private readonly IItemsCategoryRepository _itemsCategoryRepository;

        public ItemsCategoryService(IItemsCategoryRepository itemsCategoryRepository)
        {
            _itemsCategoryRepository = itemsCategoryRepository;
        }

        public async Task<IEnumerable<ItemsCategory>> GetItemsCategoriesAsync()
        {
            return await _itemsCategoryRepository.GetAllAsync();
        }

        // other methods for CRUD operations
    }
}
