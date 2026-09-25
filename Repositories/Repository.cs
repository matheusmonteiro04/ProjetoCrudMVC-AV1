using ProjetoCrudMVC.Data;
using ProjetoCrudMVC.Repositories.Interfaces;

namespace ProjetoCrudMVC.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly AppDbContext _context;

        public Repository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        public void Delete(int id)
        {
            var entidade = GetById(id);

            if (entidade != null)
            {
                _context.Set<T>().Remove(entidade);
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
