using speedkt.imagehandler;
using speedkt.people.data.Model;
using speedkt.people.data.Repository;

namespace speedkt.people.data.Service
{
    public class PersonService : IPersonService
    {
        public IUnitOfWork unitOfWork;
        public IImageStore imageStore;

        public PersonService(IUnitOfWork unitOfWork, IImageStore imageStore)
        {
            this.unitOfWork = unitOfWork;
            this.imageStore = imageStore;
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

        public void UpdateAvatar(Guid personId, string filePath)
        {
            imageStore.UploadAvatar(personId, filePath);
        }
    }
}
