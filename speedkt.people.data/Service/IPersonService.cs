using speedkt.people.data.Model;

namespace speedkt.people.data.Service
{
    public interface IPersonService
    {
        public IList<Person> GetAll();
        public Person GetById(Guid personId);
        public void UpdateBasicInfo(Person personInfo);
        public void UpdateAvatar(Person personInfo);
    }
}
