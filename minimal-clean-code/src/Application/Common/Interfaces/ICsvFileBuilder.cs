using minimal_clean_code.Application.TodoLists.Queries.ExportTodos;

namespace minimal_clean_code.Application.Common.Interfaces;
public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
