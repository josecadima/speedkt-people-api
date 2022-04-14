using speedkt.people.data.Model;

namespace speedkt.people.data.Service
{
    public interface IPersonService
    {
        public IList<Person> GetAll();
    }
}
