using MyGloboTicketManagement.Domain.Entities;


namespace MyGloboTicketManagement.Application.Contracts.Persistence
{
    public interface IOrderRepository : IAsyncRepository<Order>
    {
    }
}
