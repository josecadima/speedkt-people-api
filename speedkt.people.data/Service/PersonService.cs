using speedkt.people.data.Model;
using speedkt.people.data.Repository;

namespace speedkt.people.data.Service
{
    public class PersonService : IPersonService
    {
        public IUnitOfWork unitOfWork;

        public PersonService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IList<Person> GetAll()
        {
            return unitOfWork.Persons.All();
        }

        public Person GetById(Guid personId)
        {
            return unitOfWork.Persons.GetById(personId);
        }

        public void UpdateBasicInfo(Person personInfo)
        {
            unitOfWork.Persons.UpdateBasicInfo(personInfo);
        }

        public void UpdateAvatar(Person personInfo)
        {
            unitOfWork.Persons.UpdateAvatar(personInfo);
        }
    }
}
