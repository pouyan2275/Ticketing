using Domain.Bases.Entities;

namespace Domain.Entities;

public class DataType : BaseEntity
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public Guid? DataTypeId { get; set; }
    public ICollection<DataType>? ChildsDataType { get; set; }
}
