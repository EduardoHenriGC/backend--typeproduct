using LojaVirtual.Domain.Entities;
using LojaVirtual.Domain.Interfaces;
using LojaVirtual.Infrastructure.Data.Common;

namespace LojaVirtual.Infrastructure.Data.Repositories
{
    public class ProductRepository : EfRepository<Product>, IProductRepository
    {
        public ProductRepository(RegisterContext dbContext)
            : base(dbContext)
        {

        }
    }
}
