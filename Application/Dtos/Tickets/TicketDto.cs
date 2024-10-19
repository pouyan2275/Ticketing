using Domain.Enums;

namespace Application.Dtos.Tickets;

public class TicketDto
{
    public Guid? Id { get; set; }
    public string? Name { get; set; }
    public string? Family { get; set; }
    public string? NationalCode { get; set; }
    public Guid? TypeId { get; set; }
    public StateEnum? State { get; set; }
    public string? NoteTitle { get; set; }
    public string? NoteDescription { get; set; }
}
