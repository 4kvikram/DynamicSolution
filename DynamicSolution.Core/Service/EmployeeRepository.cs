using DynamicSolution.Core.GenericRepository;
using DynamicSolution.Core.Interface;
using DynamicSolution.DataAccess;
using DynamicSolution.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicSolution.Core.Service;

public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
{
    public EmployeeRepository(AppDbContext dbContext)
        : base(dbContext)
    {
    }

    // Add additional methods or overrides specific to the Employee entity
}
