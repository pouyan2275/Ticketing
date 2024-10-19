using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infrastructure.Bases.Data;
using Infrastructure.Bases.Data.Repositories;

namespace Infrastructure.Data.Repositories;

public class DataTypeRepository : Repository<DataType>, IDataTypeRepository
{
    public DataTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
