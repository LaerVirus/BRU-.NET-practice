using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildShopDataAccessLayer;
using BuildShopDataAccessLayer.Repositories;

namespace BuildShopBusinessAccessLayer
{
    public class ItemsCategoryService : IItemsCategoryService
    {
        private readonly IItemsCategoryRepository _itemsCategoryRepository;

        public ItemsCategoryService(IItemsCategoryRepository itemsCategoryRepository)
        {
            _itemsCategoryRepository = itemsCategoryRepository;
        }

        public async Task<IEnumerable<ItemsCategory>> GetAll()
        {
            return await _itemsCategoryRepository.GetAll();
        }

        public async Task<bool> Create(ItemsCategory itemsCategory)
        {
            return await _itemsCategoryRepository.Create(itemsCategory);
        }

		// other methods for CRUD operations
	}
}
