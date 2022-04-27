using Microsoft.EntityFrameworkCore;
using speedkt.people.data.Model;

namespace speedkt.people.data
{
    public class PeopleDbContext : DbContext
    {
        public PeopleDbContext(DbContextOptions<PeopleDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Person { get; set; }
        public DbSet<Account> Account { get; set; }
    }
}