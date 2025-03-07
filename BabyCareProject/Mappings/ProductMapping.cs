using AutoMapper;
using BabyCareProject.DataAccess.Entities;
using BabyCareProject.Dtos.ProductDtos;

namespace BabyCareProject.Mappings
{
    public class ProductMapping : Profile
    {
        public ProductMapping()
        {
            CreateMap<ResultProductDto, Product>().ReverseMap();
            CreateMap<CreateProductDto, Product>().ReverseMap();
            CreateMap<UpdateProductDto, Product>().ReverseMap();
        }
    }
}
