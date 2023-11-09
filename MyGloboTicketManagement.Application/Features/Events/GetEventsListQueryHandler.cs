using AutoMapper;
using MediatR;
using MyGloboTicketManagement.Application.Contracts.Persistence;
using MyGloboTicketManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGloboTicketManagement.Application.Features.Events
{
    public class GetEventsListQueryHandler : IRequestHandler<GetEventListQuery, List<EventListVm>>
    {
        private readonly IAsyncRepository<Event> _eventRepository;
        private readonly IMapper _mapper;
        public GetEventsListQueryHandler(IAsyncRepository<Event> eventRepository, IMapper mapper)
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
        }
        public async Task<List<EventListVm>> Handle(GetEventListQuery request, CancellationToken cancellationToken)
        {
            var allEvents = (await _eventRepository.ListAllAsync()).OrderBy(x => x.Date);
            return _mapper.Map<List<EventListVm>>(allEvents);
        }
    }
}
