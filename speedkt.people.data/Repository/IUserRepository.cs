using speedkt.people.data.Model;
using System;

namespace speedkt.people.data.Repository
{
    public interface IUserRepository : IGenericRepository<Person>
    {
        void UpdateBasicInfo(Person personInfo);
        void UpdateAvatar(Person personInfo);
    }
}
