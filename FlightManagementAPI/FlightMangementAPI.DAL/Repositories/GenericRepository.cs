using System.Collections.Generic;
using System.Linq;

namespace FlightMangementAPI.DAL.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        private readonly FlightDbContext _context;

        public BaseRepository(FlightDbContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void Edit(T entity)
        {
            _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public IEnumerable<T> GetList()
        {
            return _context.Set<T>().ToList();
        }
    }
}
