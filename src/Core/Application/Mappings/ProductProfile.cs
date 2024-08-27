using AutoMapper;
using Application.Features.Products.Commands.AddEdit;
using Domain.Entities.Catalog;

namespace Application.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<AddEditProductCommand, Product>().ReverseMap();
        }
    }
}