
using CodingExcercise.Models;
using Microsoft.EntityFrameworkCore;
namespace CodingExcercise.Data
{
    public class FinanceContext : DbContext
    {
        public FinanceContext(DbContextOptions<FinanceContext> options) : base(options)
        {
        }
        //These three DBSets represent each of the tables that are used for this sample
        public DbSet<Investment> Investment { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Investment>().ToTable("Investments");
            modelBuilder.Entity<Transaction>().ToTable("Transactions");
            modelBuilder.Entity<User>().ToTable("Users");
        }
    }

}
