using speedkt.people.data.Model;

namespace speedkt.people.data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public IUserRepository Persons { get; private set; }
        public IAccountRepository Accounts { get; private set; }

        public UnitOfWork(PeopleDbContext dbContext)
        {
            this.Persons = new UserRepository(dbContext);
            this.Accounts = new AccountRepository(dbContext);
        }
    }
}
