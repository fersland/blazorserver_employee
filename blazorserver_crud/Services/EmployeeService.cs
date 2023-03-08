using EmployeeManagement.Shared;

namespace blazorserver_crud.Services
{
    public class EmployeeService : ServiceBase<Employee>
    {
        public EmployeeService(AppDbContext db) : base (db){}
    }
}
