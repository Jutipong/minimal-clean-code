using MediatR;
using Microsoft.Extensions.Logging;
using minimal_clean_code.Domain.Events;

namespace minimal_clean_code.Application.TodoItems.EventHandlers;
public class TodoItemCompletedEventHandler : INotificationHandler<TodoItemCompletedEvent>
{
    private readonly ILogger<TodoItemCompletedEventHandler> _logger;

    public TodoItemCompletedEventHandler(ILogger<TodoItemCompletedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(TodoItemCompletedEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("minimal_clean_code Domain Event: {DomainEvent}", notification.GetType().Name);

        return Task.CompletedTask;
    }
}
