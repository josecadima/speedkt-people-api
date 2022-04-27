using speedkt.people.data.Model;
using speedkt.people.data.Repository;

namespace speedkt.people.data.Service
{
    public class AccountService : IAccountService
    {
        public IUnitOfWork unitOfWork;

        public AccountService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public Account GetByAuth0Id(string auth0Id)
        {
            return unitOfWork.Accounts.GetByAuth0Id(auth0Id);
        }
    }
}
