using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using BuildShopPresentationLayer;
using Microsoft.EntityFrameworkCore;

namespace BuildShopBusinessAccessLayer
{
    public class DeliveryService : IDeliveryService
    {
        private readonly IDeliveryRepository _deliveryRepository;

        public DeliveryService(IDeliveryRepository deliveryRepository)
        {
            _deliveryRepository = deliveryRepository;
        }

        public async Task<IEnumerable<Delivery>> GetDeliveriesAsync()
        {
            return await _deliveryRepository.GetAllAsync();
        }

        // other methods for CRUD operations
    }
}
