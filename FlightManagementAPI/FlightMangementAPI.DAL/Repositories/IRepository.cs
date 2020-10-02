using System.Collections.Generic;

namespace FlightMangementAPI.DAL.Repositories
{
    public interface IRepository<T>
    {
        T GetById(int id);
        IEnumerable<T> GetList();
        void Add(T entity);
        void Delete(T Entity);
        void Edit(T Entity);
    }
}
