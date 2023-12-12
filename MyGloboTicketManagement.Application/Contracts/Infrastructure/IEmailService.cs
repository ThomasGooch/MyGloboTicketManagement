using MyGloboTicketManagement.Application.Models.Mail;

namespace MyGloboTicketManagement.Application.Contracts.Infrastructure
{
    public interface IEmailService
    {
        Task<bool> SendEmail(Email email);
    }
}
