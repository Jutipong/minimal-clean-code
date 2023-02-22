using System.Globalization;
using CsvHelper;
using minimal_clean_code.Application.Common.Interfaces;
using minimal_clean_code.Application.TodoLists.Queries.ExportTodos;
using minimal_clean_code.Infrastructure.Files.Maps;

namespace minimal_clean_code.Infrastructure.Files;
public class CsvFileBuilder : ICsvFileBuilder
{
    public byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records)
    {
        using var memoryStream = new MemoryStream();
        using (var streamWriter = new StreamWriter(memoryStream))
        {
            using var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);

            csvWriter.Context.RegisterClassMap<TodoItemRecordMap>();
            csvWriter.WriteRecords(records);
        }

        return memoryStream.ToArray();
    }
}
