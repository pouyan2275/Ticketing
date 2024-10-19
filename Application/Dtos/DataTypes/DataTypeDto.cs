using Domain.Entities;

namespace Application.Dtos.DataTypes;

public class DataTypeDto
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public Guid? ParentId { get; set; }
    public DataType? Parent { get; set; }
    public ICollection<DataType> SubDataType { get; } = [];
}
