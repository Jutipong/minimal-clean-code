using FluentAssertions;
using minimal_clean_code.Application.Common.Exceptions;
using minimal_clean_code.Application.TodoItems.Commands.CreateTodoItem;
using minimal_clean_code.Application.TodoItems.Commands.DeleteTodoItem;
using minimal_clean_code.Application.TodoLists.Commands.CreateTodoList;
using minimal_clean_code.Domain.Entities;
using NUnit.Framework;

using static minimal_clean_code.Application.IntegrationTests.Testing;

namespace minimal_clean_code.Application.IntegrationTests.TodoItems.Commands;
public class DeleteTodoItemTests : BaseTestFixture
{
    [Test]
    public async Task ShouldRequireValidTodoItemId()
    {
        var command = new DeleteTodoItemCommand(99);

        await FluentActions.Invoking(() =>
            SendAsync(command)).Should().ThrowAsync<NotFoundException>();
    }

    [Test]
    public async Task ShouldDeleteTodoItem()
    {
        var listId = await SendAsync(new CreateTodoListCommand
        {
            Title = "New List"
        });

        var itemId = await SendAsync(new CreateTodoItemCommand
        {
            ListId = listId,
            Title = "New Item"
        });

        await SendAsync(new DeleteTodoItemCommand(itemId));

        var item = await FindAsync<TodoItem>(itemId);

        item.Should().BeNull();
    }
}
