using EmployeeAppAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAppAPI.Data
{
    public class EmployeeAppContext : DbContext
    {
        public EmployeeAppContext(DbContextOptions<EmployeeAppContext> options)
            : base(options)
        {

        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<SystemCode> SystemCodes { get; set; }
        public DbSet<SystemCodeDetail> SystemCodeDetails { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
