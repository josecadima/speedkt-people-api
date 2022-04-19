using speedkt.people.data.Model;

namespace speedkt.people.data.Repository
{
    public interface IUnitOfWork
    {
        IUserRepository Persons { get; }
    }
}
