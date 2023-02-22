using MediatR;
using Microsoft.Extensions.Logging;
using minimal_clean_code.Domain.Events;

namespace minimal_clean_code.Application.TodoItems.EventHandlers;
public class TodoItemCreatedEventHandler : INotificationHandler<TodoItemCreatedEvent>
{
    private readonly ILogger<TodoItemCreatedEventHandler> _logger;

    public TodoItemCreatedEventHandler(ILogger<TodoItemCreatedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(TodoItemCreatedEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("minimal_clean_code Domain Event: {DomainEvent}", notification.GetType().Name);

        return Task.CompletedTask;
    }
}
