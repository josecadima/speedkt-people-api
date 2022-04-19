using System;

namespace speedkt.people.data.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        IList<T> All();
        T GetById(Guid id);
        Task<IList<T>> AllAsync();
        Task<T> GetByIdAsync(Guid id);
        Task<T> Add(T entity);
        Task Update(T entity);
        Task Delete(T entity);
    }
}
