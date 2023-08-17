using DynamicSolution.Core.GenericRepository;
using DynamicSolution.Core.Mapper;
using DynamicSolution.DataAccess.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DynamicSolution.Core.Interface;
namespace DynamicSolution.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmployeeController : GenericController<Employee, EmployeeDto>
{
    public EmployeeController(
        IEmployeeRepository repository,
        IEntityDtoMapper<Employee, EmployeeDto> mapper)
        : base(repository, mapper)
    {
    }

    public IActionResult Something()
    {

        return Ok();
    }
}
