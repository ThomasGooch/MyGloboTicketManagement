
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyGloboTicketManagement.Application.Contracts.Infrastructure;
using MyGloboTicketManagement.Application.Models.Mail;
using MyGloboTicketManagement.Infrastructure.Mail;

namespace MyGloboTicketManagement.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));

            services.AddTransient<IEmailService, EmailService>();

            return services;
        }
    }
}
