using Domain.Bases.Entities;
using Domain.Enums;

namespace Domain.Entities;

public class Ticket : BaseEntity
{   
    public string? Name { get; set; }
    public string? Family { get; set; }
    public string? NationalCode { get; set; }
    public StateEnum? State { get; set; }
    public Guid? NoteId { get; set; }
    public ICollection<Note?> Note { get; set; } = [];
}
