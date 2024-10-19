

using Domain.Entities;
using Domain.Enums;

namespace Application.Dtos.Tickets;

public class TicketDtoSelect
{
    public string? Name { get; set; }
    public string? Family { get; set; }
    public string? NationalCode { get; set; }
    public Guid? StateId { get; set; }
    public StateEnum? State { get; set; }
    public Guid? NoteId { get; set; }
    public ICollection<Note?>? Note { get; set; }
}
