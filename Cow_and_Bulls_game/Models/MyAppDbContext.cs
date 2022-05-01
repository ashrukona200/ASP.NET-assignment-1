using System.Data.Entity;
namespace Cow_and_Bulls_game.Models
{
    public class MyAppDbContext : DbContext
    {
        public MyAppDbContext()
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
