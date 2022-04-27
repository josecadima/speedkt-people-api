using speedkt.people.data.Model;

namespace speedkt.people.data.Repository
{
    public interface IAccountRepository : IGenericRepository<Account>
    {
        Account GetByAuth0Id(string auth0Id);
    }
}
