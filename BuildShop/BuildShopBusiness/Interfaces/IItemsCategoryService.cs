using BuildShopDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildShopBusinessAccessLayer
{
    public interface IItemsCategoryService
    {
        Task<IEnumerable<ItemsCategory>> GetAll();
        Task<bool> Create(ItemsCategory itemsCategory);
	}
}
