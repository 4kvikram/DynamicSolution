using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicSolution.Core.Mapper;

public class EntityDtoMapper<TEntity, TDto> : IEntityDtoMapper<TEntity, TDto>
    where TEntity : class
    where TDto : class
{
    public TDto MapEntityToDto(TEntity entity)
    {
        TDto dto = Activator.CreateInstance<TDto>();
        // Implement reflection-based property mapping here
        // Example:
        foreach (var entityProperty in typeof(TEntity).GetProperties())
        {
            var dtoProperty = typeof(TDto).GetProperty(entityProperty.Name);
            if (dtoProperty != null)
            {
                dtoProperty.SetValue(dto, entityProperty.GetValue(entity));
            }
        }
        return dto;
    }

    public TEntity MapDtoToEntity(TDto dto)
    {
        TEntity entity = Activator.CreateInstance<TEntity>();
        // Implement reflection-based property mapping here
        // Example:
        foreach (var dtoProperty in typeof(TDto).GetProperties())
        {
            var entityProperty = typeof(TEntity).GetProperty(dtoProperty.Name);
            if (entityProperty != null)
            {
                entityProperty.SetValue(entity, dtoProperty.GetValue(dto));
            }
        }
        return entity;
    }
    public List<TDto> MapEntityListToDtoList(IEnumerable<TEntity> entityList)
    {
        var dtoList = new List<TDto>();
        foreach (var entity in entityList)
        {
            var dto = MapEntityToDto(entity);
            dtoList.Add(dto);
        }
        return dtoList;
    }
}
