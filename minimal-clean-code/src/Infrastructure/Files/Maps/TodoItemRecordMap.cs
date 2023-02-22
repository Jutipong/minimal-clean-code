using System.Globalization;
using CsvHelper.Configuration;
using minimal_clean_code.Application.TodoLists.Queries.ExportTodos;

namespace minimal_clean_code.Infrastructure.Files.Maps;
public class TodoItemRecordMap : ClassMap<TodoItemRecord>
{
    public TodoItemRecordMap()
    {
        AutoMap(CultureInfo.InvariantCulture);

        Map(m => m.Done).Convert(c => c.Value.Done ? "Yes" : "No");
    }
}
