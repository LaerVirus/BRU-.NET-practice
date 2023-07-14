using BuildShopPresentationLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildShopBusinessAccessLayer
{
    public interface IDeliveryService
    {
        Task<IEnumerable<Delivery>> GetDeliveriesAsync();

    }
}
