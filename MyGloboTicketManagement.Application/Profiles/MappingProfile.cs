using AutoMapper;
using MyGloboTicketManagement.Application.Features.Events;
using MyGloboTicketManagement.Domain.Entities;

namespace MyGloboTicketManagement.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Event, EventListVm>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();
            CreateMap<Category, CategoryDto>();
        }
    }
}
