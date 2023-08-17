using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicSolution.Core.Mapper;

public interface IEntityDtoMapper<TEntity, TDto>
{
    TDto MapEntityToDto(TEntity entity);
    TEntity MapDtoToEntity(TDto dto);
}

