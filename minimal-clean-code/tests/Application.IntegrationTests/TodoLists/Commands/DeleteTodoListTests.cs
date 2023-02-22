using FluentAssertions;
using minimal_clean_code.Application.Common.Exceptions;
using minimal_clean_code.Application.TodoLists.Commands.CreateTodoList;
using minimal_clean_code.Application.TodoLists.Commands.DeleteTodoList;
using minimal_clean_code.Domain.Entities;
using NUnit.Framework;

using static minimal_clean_code.Application.IntegrationTests.Testing;

namespace minimal_clean_code.Application.IntegrationTests.TodoLists.Commands;
public class DeleteTodoListTests : BaseTestFixture
{
    [Test]
    public async Task ShouldRequireValidTodoListId()
    {
        var command = new DeleteTodoListCommand(99);
        await FluentActions.Invoking(() => SendAsync(command)).Should().ThrowAsync<NotFoundException>();
    }

    [Test]
    public async Task ShouldDeleteTodoList()
    {
        var listId = await SendAsync(new CreateTodoListCommand
        {
            Title = "New List"
        });

        await SendAsync(new DeleteTodoListCommand(listId));

        var list = await FindAsync<TodoList>(listId);

        list.Should().BeNull();
    }
}
