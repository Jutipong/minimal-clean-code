using minimal_clean_code.Application.Common.Mappings;
using minimal_clean_code.Domain.Entities;

namespace minimal_clean_code.Application.Common.Models;
// Note: This is currently just used to demonstrate applying multiple IMapFrom attributes.
public class LookupDto : IMapFrom<TodoList>, IMapFrom<TodoItem>
{
    public int Id { get; set; }

    public string? Title { get; set; }
}
