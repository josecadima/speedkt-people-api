using speedkt.people.data.Model;

namespace speedkt.people.data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private PeopleDbContext dbContext;

        public IGenericRepository<Person> Persons { get; private set; }

        public UnitOfWork(PeopleDbContext dbContext)
        {
            this.dbContext = dbContext;

            this.Persons = new GenericRepository<Person>(dbContext);
        }
    }
}
