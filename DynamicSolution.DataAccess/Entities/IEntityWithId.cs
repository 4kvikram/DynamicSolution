using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicSolution.DataAccess.Entities
{
    public interface IEntityWithId
    {
        int Id { get; }
    }
}
