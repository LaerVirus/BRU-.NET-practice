using BuildShopPresentationLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildShopBusinessAccessLayer
{
    public interface IOrderedItemService
    {
        Task<IEnumerable<OrderedItem>> GetOrderedItemsAsync();

    }
}
