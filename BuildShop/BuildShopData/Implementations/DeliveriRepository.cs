using BuildShopDataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BuildShopDataAccessLayer.Implementations
{
    public class DeliveriRepository : IDeliveryRepository
    {
        private readonly BuildShopContext _context;

        public DeliveriRepository(BuildShopContext context)
        {
            _context = context;
        }

        public Task<bool> Create(DeliveriRepository entity)
        {
            if (entity == null)
            {
                return Task.FromResult(false);
            }

            _context.Delivery.Add(entity);

            return Task.FromResult(_context.SaveChangesAsync().Result != 0);
        }

        public Task<bool> Delete(DeliveriRepository entity)
        {
            if (entity == null)
            {
                return Task.FromResult(false);
            }

            _context.Delivery.Remove(entity);

            return Task.FromResult(_context.SaveChangesAsync().Result != 0);
        }

        public Task<List<Delivery>> GetAll()
        {
            return _context.Delivery.ToListAsync();
        }

        public Task<Delivery> GetById(Guid id)
        {
            return _context.Delivery.FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task<bool> Update(Delivery entity)
        {
            if (entity == null)
            {
                return Task.FromResult(false);
            }

            return Task.FromResult(_context.SaveChangesAsync().Result != 0);
        }
    }
}
