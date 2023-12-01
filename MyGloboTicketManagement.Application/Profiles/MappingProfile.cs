using AutoMapper;
using MyGloboTicketManagement.Application.Features.Categories.Queries.GetCategoriesList;
using MyGloboTicketManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using MyGloboTicketManagement.Application.Features.Events.Commands.CreateEvent;
using MyGloboTicketManagement.Application.Features.Events.Commands.DeleteEvent;
using MyGloboTicketManagement.Application.Features.Events.Commands.UpdateEvent;
using MyGloboTicketManagement.Application.Features.Events.Queries.GetEventDetail;
using MyGloboTicketManagement.Application.Features.Events.Queries.GetEventsList;
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
            CreateMap<Category, CategoryListVm>();
            CreateMap<Category, CategoryEventListVm>();
            CreateMap<Event, CreateEventCommand>().ReverseMap();
            CreateMap<Event, DeleteEventCommand>().ReverseMap();
            CreateMap<Event, UpdateEventCommand>().ReverseMap();
        }
    }
}
