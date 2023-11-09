using MyGloboTicketManagement.Domain.Entities;

namespace MyGloboTicketManagement.Application.Contracts.Persistence
{
    public interface IEventRepository: IAsyncRepository<Event>
    {
    }
}
