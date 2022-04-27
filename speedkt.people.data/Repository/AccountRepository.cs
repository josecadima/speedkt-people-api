using speedkt.people.data.Model;

namespace speedkt.people.data.Repository
{
    public class AccountRepository : GenericRepository<Account>, IAccountRepository
    {
        public AccountRepository(PeopleDbContext dbContext) : base(dbContext)
        {   
        }

        public Account GetByAuth0Id(string auth0Id)
        {
            return dbContext.Account.Where(a => a.Auth0Id == auth0Id).FirstOrDefault();
        }
    }
}
