using Invoicing.Application.Common.Interfaces;

namespace Invoicing.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
