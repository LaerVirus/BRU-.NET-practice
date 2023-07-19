using BuildShopDataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BuildShopDataAccessLayer.Implementations
{
    public class DeliveryRepository : IDeliveryRepository
    {
        private readonly BuildShopContext _context;

        public DeliveryRepository(BuildShopContext context)
        {
            _context = context;
        }

        public Task<bool> Create(Delivery entity)
        {
            if (entity == null)
            {
                return Task.FromResult(false);
            }

            _context.Deliveries.Add(entity);

            return Task.FromResult(_context.SaveChangesAsync().Result != 0);
        }

        public Task<bool> Delete(Delivery entity)
        {
            if (entity == null)
            {
                return Task.FromResult(false);
            }

            _context.Deliveries.Remove(entity);

            return Task.FromResult(_context.SaveChangesAsync().Result != 0);
        }

        public Task<List<Delivery>> GetAll()
        {
            return _context.Deliveries.ToListAsync();
        }

        public Task<Delivery> GetById(Guid id)
        {
            return _context.Deliveries.FirstOrDefaultAsync(x => x.OrderedId == id);
        }

        public Task<bool> Update(Delivery entity)
        {
            if (entity == null)
            {
                return Task.FromResult(false);
            }

			_context.Deliveries.Update(entity);

			return Task.FromResult(_context.SaveChangesAsync().Result != 0);
        }
    }
}
