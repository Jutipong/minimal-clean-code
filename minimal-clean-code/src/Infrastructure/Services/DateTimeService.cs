using minimal_clean_code.Application.Common.Interfaces;

namespace minimal_clean_code.Infrastructure.Services;
public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
