using Application.IServices;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;
using Personal.Server.Bases.Controllers;

namespace Personal.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataTypeController : BaseController<DataType>
    {
        private readonly IDataTypeService _service;
        private readonly IDataTypeRepository _repository;

        public DataTypeController(IDataTypeService DataTypeService, IDataTypeRepository repository) : base(DataTypeService)
        {
            _service = DataTypeService;
            _repository = repository;
        }
    }
}
