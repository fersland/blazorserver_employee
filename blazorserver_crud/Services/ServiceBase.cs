using blazorserver_crud.Interfaces;

namespace blazorserver_crud.Services
{
    public class ServiceBase<T> : ICrud<T> where T:class
    {
        readonly AppDbContext db;
        protected IQueryable<T> Entities { get => db.Set<T>(); }

        public ServiceBase(AppDbContext db)
        {
            this.db = db;
        }

        public bool Add(T entity)
        {
            try
            {
                db.Set<T>().Add(entity);
                return db.SaveChanges() != 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(T entity)
        {
            try
            {
                db.Set<T>().Remove(entity);
                return db.SaveChanges() != 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(T entity)
        {
            try
            {
                db.Set<T>().Update(entity);
                return db.SaveChanges() != 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public T GetById(int id)
        {
            return db.Set<T>().Find(id);
        }

        public List<T> GetAll()
        {
            return db.Set<T>().ToList();
        }
    }
}
