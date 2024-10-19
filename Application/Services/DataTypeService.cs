using Application.Bases.Implements.Services;
using Application.IServices;
using Domain.Entities;
using Domain.Interfaces.Repositories;
namespace Application.Services;

public class DataTypeService : BaseService<DataType>, IDataTypeService
{
    private readonly IDataTypeRepository _repository;

    public DataTypeService(IDataTypeRepository repository) : base(repository)
    {
        _repository = repository;
    }


}
