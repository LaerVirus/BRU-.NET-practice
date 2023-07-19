using BuildShopDataAccessLayer;
using BuildShopDataAccessLayer.Repositories;

namespace BuildShopBusinessAccessLayer
{
    public class DeliveryService : IDeliveryService
    {
        private readonly IDeliveryRepository _deliveryRepository;

        public DeliveryService(IDeliveryRepository deliveryRepository)
        {
            _deliveryRepository = deliveryRepository;
        }

        public async Task<IEnumerable<Delivery>> GetAll()
        {
            return await _deliveryRepository.GetAll();
        }

        public async Task<Delivery> GetById(int orderId)
        {

        }

		Task<Delivery> Create(Delivery delivery);
		Task<Delivery> Delete(int orderedid);
		Task<Delivery> Update(Delivery delivery);
	}
}
