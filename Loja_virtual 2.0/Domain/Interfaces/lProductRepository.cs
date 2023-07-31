using LojaVirtual.Domain.Entities;
using System.Collections.Generic;

namespace LojaVirtual.Domain.Interfaces
{
    public interface IProductRepository
    {

        Product Get(int id);
        IEnumerable<Product> GetAll();
        void Insert(Product client);
        void Update(Product client);
        void Delete(int id);
    }
}
