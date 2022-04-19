using speedkt.people.data.Model;
using System;

namespace speedkt.people.data.Repository
{
    public class UserRepository : GenericRepository<Person>, IUserRepository
    {
        public UserRepository(PeopleDbContext dbContext) : base(dbContext)
        {
        }

        public void UpdateBasicInfo(Person personInfo)
        {
            var person = dbContext.Person.Find(personInfo.PersonId);
            if (person == null)
                return;

            person.FirstName = personInfo.FirstName;
            person.LastName = personInfo.LastName;
            person.NickName = personInfo.NickName;
            
            dbContext.SaveChanges();
        }

        public void UpdateAvatar(Person personInfo)
        {
            throw new NotImplementedException();
        }
    }
}
