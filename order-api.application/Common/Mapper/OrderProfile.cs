using AutoMapper;
using order_api.application.Orders.Models;
using order_api.domain.Entities;

namespace order_api.application.Common.Mapper
{
    public class TodoItemProfile : Profile
    {
        public TodoItemProfile()
        {
            CreateMap<Order, OrderDto>()
                .ForMember(x => x.Id, opt => opt.MapFrom(o => o.Id))
                .ForMember(x => x.Name, opt => opt.MapFrom(o => o.Name))
                .ForMember(x => x.SourceNote, opt => opt.MapFrom(o => o.SourceNote))
                .ForMember(x => x.Cost, opt => opt.MapFrom(o => o.Cost));


            CreateMap<OrderDto, Order>()
                .ForMember(x => x.Id, opt => opt.MapFrom(o => o.Id))
                .ForMember(x => x.Name, opt => opt.MapFrom(o => o.Name))
                .ForMember(x => x.SourceNote, opt => opt.MapFrom(o => o.SourceNote))
                .ForMember(x => x.Cost, opt => opt.MapFrom(o => o.Cost));
        }
    }
}