using EmployeeManagement.Shared;

namespace blazorserver_crud.Services
{
    public class DepartmentService : ServiceBase<Department>
    {
        public DepartmentService(AppDbContext db) : base(db){}

    }
}
