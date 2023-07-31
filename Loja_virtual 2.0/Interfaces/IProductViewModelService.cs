using LojaVirtual.ViewModels;
using System.Collections.Generic;

namespace LojaVirtual.Interfaces
{
    public interface IProductViewModelService
    {

        ProductViewModel Get(int id);
        IEnumerable<ProductViewModel> GetAll(string filter, string sortOrder);
        void Insert(ProductViewModel viewModel);
        void Update(ProductViewModel viewModel);
        void Delete(int id);

    }
}
