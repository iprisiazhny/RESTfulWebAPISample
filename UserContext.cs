using Microsoft.EntityFrameworkCore;

namespace RESTfulWebAPISample
{
    public class UserContext: DbContext 
    {
        public UserContext()
        {}

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer("server=RustenUltraBook;Database=UserInfo;Trusted_Connection=True;");
        }
    }
}
