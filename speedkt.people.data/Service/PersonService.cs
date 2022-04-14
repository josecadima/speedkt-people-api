using speedkt.people.data.Model;
using speedkt.people.data.Repository;
using System;

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
    }
}
