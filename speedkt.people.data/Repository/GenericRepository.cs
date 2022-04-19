using Microsoft.EntityFrameworkCore;

namespace speedkt.people.data.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected PeopleDbContext dbContext;
        protected DbSet<T> dbSet;

        public GenericRepository(PeopleDbContext dbContext)
        {
            this.dbContext = dbContext;

            this.dbSet = dbContext.Set<T>();
        }

        public IList<T> All()
        {
            return dbSet.ToList();
        }

        public async Task<IList<T>> AllAsync()
        {
            return await dbSet.ToListAsync();
        }

        public Task<T> Add(T entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public T GetById(Guid id)
        {
            return dbSet.Find(id);
        }

        public void Update(T entity)
        {
            dbSet.Update(entity);
        }
    }
}
