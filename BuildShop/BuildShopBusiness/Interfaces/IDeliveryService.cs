using BuildShopDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildShopBusinessAccessLayer
{
    public interface IDeliveryService
    {
        Task<IEnumerable<Delivery>> GetAll();
		Task<Delivery> GetById(int orderId);
		Task<Delivery> Create(Delivery delivery);
		Task<Delivery> Delete(int orderId);
		Task<Delivery> Update(Delivery delivery);
	}
}
