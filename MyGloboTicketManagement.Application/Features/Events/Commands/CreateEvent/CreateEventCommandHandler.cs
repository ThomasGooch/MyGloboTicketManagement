using AutoMapper;
using MediatR;
using MyGloboTicketManagement.Application.Contracts.Infrastructure;
using MyGloboTicketManagement.Application.Contracts.Persistence;
using MyGloboTicketManagement.Application.Models.Mail;
using MyGloboTicketManagement.Domain.Entities;

namespace MyGloboTicketManagement.Application.Features.Events.Commands.CreateEvent
{
    public class CreateEventCommandHandler : IRequestHandler<CreateEventCommand, Guid>
    {
        private readonly IEventRepository _eventRepository;
        private readonly IMapper _mapper;
        private readonly IEmailService _emailService;


        public CreateEventCommandHandler(IMapper mapper, IEventRepository eventRepository, IEmailService emailService)
        {
            _mapper = mapper;
            _eventRepository = eventRepository;
            _emailService = emailService;
        }

        public async Task<Guid> Handle(CreateEventCommand request, CancellationToken cancellationToken)
        {

            var validator = new CreateEventCommandValidator(_eventRepository);
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (validationResult.Errors.Count > 0)
            {
                throw new Exceptions.ValidationException(validationResult);
            }

            var @event = _mapper.Map<Event>(request);


            @event = await _eventRepository.AddAsync(@event);

            var email = new Email() { To = "gill@snowball.cbe", Subject = "new event created", Body = $"a new event was created: {request}" };

            try
            {
                await _emailService.SendEmail(email);
            }
            catch (Exception ex)
            {

                // this shouldn't stop the process, should be logged.
            }

            return @event.EventId;
        }
    }
}