using EmployeeManagement.Shared;
using Microsoft.EntityFrameworkCore;

namespace blazorserver_crud
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public virtual DbSet<Employee> Employees => Set<Employee>();
        public virtual DbSet<Department> Departments => Set<Department>();
    }
}
