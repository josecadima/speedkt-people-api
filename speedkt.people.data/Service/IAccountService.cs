using speedkt.people.data.Model;

namespace speedkt.people.data.Service
{
    public interface IAccountService
    {
        Account GetByAuth0Id(string auth0Id);
    }
}
