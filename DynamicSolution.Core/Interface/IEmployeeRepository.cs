using DynamicSolution.Core.GenericRepository;
using DynamicSolution.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicSolution.Core.Interface
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
    }
}
