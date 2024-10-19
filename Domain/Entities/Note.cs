using Domain.Bases.Entities;
using Domain.Enums;

namespace Domain.Entities;

public class Note : BaseEntity
{
    public string? Description { get; set; }
    public string? Title { get; set; }
    public StateEnum? State { get; set; }
    public Guid TicketId { get; set; }
}
