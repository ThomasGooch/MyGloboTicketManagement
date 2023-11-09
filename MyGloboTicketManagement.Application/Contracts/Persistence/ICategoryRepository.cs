using MyGloboTicketManagement.Domain.Entities;

namespace MyGloboTicketManagement.Application.Contracts.Persistence
{
    public interface ICategoryRepository : IAsyncRepository<Category>
    {
    }
}
