using MediatR;

namespace MyGloboTicketManagement.Application.Features.Events
{
    public class GetEventDetailQuery: IRequest<EventDetailVm>
    {
        public Guid Id { get; set; }
    }
}
