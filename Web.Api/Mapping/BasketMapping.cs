using AutoMapper;
using OrderSync.DtoLayer.BasketDto;
using OrderSync.EntityLayer.Entities;

namespace Web.Api.Mapping
{
    public class BasketMapping : Profile
    { 
        public BasketMapping()
        {
            CreateMap<Basket, CreateBasketDto>().ReverseMap();
        }
    }
}
