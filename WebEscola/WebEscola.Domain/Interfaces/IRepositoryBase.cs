using System.Collections.Generic;

namespace WebEscola.Domain.Interfaces
{
    public interface IRepositoryBase<T> where T : class
    {
        public int Add(T entity);
        public void Update(T entity);

        public T FindById(int id);

        public IEnumerable<T> GetAll();

        public void Remove(int id);
       
    }
}