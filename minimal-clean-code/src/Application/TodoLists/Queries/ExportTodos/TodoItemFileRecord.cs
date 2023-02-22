using minimal_clean_code.Application.Common.Mappings;
using minimal_clean_code.Domain.Entities;

namespace minimal_clean_code.Application.TodoLists.Queries.ExportTodos;
public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
