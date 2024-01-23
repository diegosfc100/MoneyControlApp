using Microsoft.EntityFrameworkCore;

namespace MoneyNote.Models
{
    public class AplicationDbContext:DbContext
    {
        public AplicationDbContext(DbContextOptions options): base(options)
        {
            
        }

        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
