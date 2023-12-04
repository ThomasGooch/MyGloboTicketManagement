

using MediatR;

namespace MyGloboTicketManagement.Application.Features.Events.Queries.GetEventsList
{
    public class GetEventListQuery : IRequest<List<EventListVm>>
    {
    }
}
