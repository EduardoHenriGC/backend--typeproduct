using AutoMapper;
using LojaVirtual.Domain.Entities;
using LojaVirtual.ViewModels;

namespace LojaVirtual.Infrastructure.Web
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            
            CreateMap<Product, ProductViewModel>();
            CreateMap<ProductViewModel, Product>();
        }
    }
}
