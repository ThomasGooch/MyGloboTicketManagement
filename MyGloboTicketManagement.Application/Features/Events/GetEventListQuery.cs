

using MediatR;

namespace MyGloboTicketManagement.Application.Features.Events
{
    public class GetEventListQuery : IRequest<List<EventListVm>>
    {
    }
}
