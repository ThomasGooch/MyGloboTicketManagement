using Microsoft.Extensions.Options;
using MyGloboTicketManagement.Application.Contracts.Infrastructure;
using MyGloboTicketManagement.Application.Models.Mail;
using System.Text.Json;

namespace MyGloboTicketManagement.Infrastructure.Mail
{
    public class EmailService : IEmailService
    {
        private readonly EmailSettings _emailSettings;

        public EmailService(IOptions<EmailSettings> mailSettings)
        {
            _emailSettings = mailSettings.Value;
        }
        public Task<bool> SendEmail(Email email)
        {
            Console.WriteLine("email sent with configuration: {0} - and Email: {1}", JsonSerializer.Serialize(_emailSettings), JsonSerializer.Serialize(email));
            return Task.FromResult(true);

        }
    }
}
