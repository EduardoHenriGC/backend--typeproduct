using AutoMapper;
using LojaVirtual.Domain.Entities;
using LojaVirtual.Domain.Interfaces;
using LojaVirtual.Interfaces;
using LojaVirtual.ViewModels;
using System.Collections.Generic;

namespace LojaVirtual.Services
{
    public class ProductViewModelService : IProductViewModelService
    {
        private readonly IProductRepository _productRepository;
        
        private readonly IMapper _mapper;

        public ProductViewModelService(IProductRepository productRepository,  IMapper mapper)
        {
            _productRepository = productRepository;
            
            _mapper = mapper;
        }

        public void Delete(int id)
        {
            _productRepository.Delete(id);
        }

        public ProductViewModel Get(int id)
        {
            var entity = _productRepository.Get(id);
            if (entity == null)
                return null;

            return _mapper.Map<ProductViewModel>(entity);
        }


        public IEnumerable<ProductViewModel> GetAll(string filter, string sortOrder)
        {
            var products = _productRepository.GetAll();

            if (!string.IsNullOrEmpty(filter) && filter.ToLower() != "all")
            {
                products = products.Where(p => p.type == filter);
            }

            if (!string.IsNullOrEmpty(sortOrder) && sortOrder.ToLower() == "desc")
            {
                products = products.OrderByDescending(p => p.price);
            }
            else
            {
                products = products.OrderBy(p => p.price);
            }

            return _mapper.Map<IEnumerable<ProductViewModel>>(products);
        }

        public void Insert(ProductViewModel viewModel)
        {
            var entity = _mapper.Map<Product>(viewModel);


            _productRepository.Insert(entity);
        }

        public void Update(ProductViewModel viewModel)
        {
            var entity = _mapper.Map<Product>(viewModel);

            _productRepository.Update(entity);
        }
    }
}
