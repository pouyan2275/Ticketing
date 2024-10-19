using Domain.Entities;

namespace Application.Dtos.DataTypes;

public class DataTypeDtoSelect
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public ICollection<DataType> SubDataType { get; } = [];
}
