using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicSolution.DataAccess.Entities
{
    public class Users: IEntityWithId
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class Employee : IEntityWithId
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class Project : IEntityWithId
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // Other properties...
    }
}
