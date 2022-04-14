using Microsoft.EntityFrameworkCore;

namespace speedkt.people.data.Repository
{
    internal class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private PeopleDbContext dbContext;
        private DbSet<T> dbSet;

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

        public Task<T> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
