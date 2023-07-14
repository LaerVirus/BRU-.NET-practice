using BuildShopPresentationLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildShopBusinessAccessLayer
{
    public interface IOrderService
    {
        Task<IEnumerable<Order>> GetOrdersAsync();
    }
}
