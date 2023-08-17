using DynamicSolution.Core.GenericRepository;
using DynamicSolution.Core.Mapper;
using DynamicSolution.DataAccess.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DynamicSolution.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GenericController<TEntity, TDto> : ControllerBase
    where TEntity : class, IEntityWithId
    where TDto : class
{
    private readonly IRepository<TEntity> _repository;
    private readonly IEntityDtoMapper<TEntity, TDto> _mapper;

    public GenericController(IRepository<TEntity> repository, IEntityDtoMapper<TEntity, TDto> mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var entity = _repository.GetById(id);
        if (entity == null)
            return NotFound();

        var dto = _mapper.MapEntityToDto(entity);
        return Ok(dto);

    }
    [HttpGet]
    public IActionResult Get()
    {
        var entity = _repository.GetAll();
        if (entity == null)
            return NotFound();

       // =var dto = _mapper.MapEntityToDto(entity);
        return Ok(entity);
    }

    [HttpPost]
    public IActionResult Post([FromBody] TDto dto)
    {
        if (!ModelState.IsValid)
            return BadRequest();

        var entity = _mapper.MapDtoToEntity(dto);
        _repository.Add(entity);
        // Return the created entity as a DTO if needed
        return CreatedAtAction(nameof(Get), new { id = entity.Id }, dto);
    }

    // Implement other actions
}
