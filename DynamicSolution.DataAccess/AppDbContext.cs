using DynamicSolution.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DynamicSolution.DataAccess
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public virtual DbSet<Users> Users { get; set; }

    }
}