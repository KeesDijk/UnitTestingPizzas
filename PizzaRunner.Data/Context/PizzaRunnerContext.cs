using PizzaRunner.Data.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PizzaRunner.Data.Context
{
    public class PizzaRunnerContext : DbContext
    {
        public PizzaRunnerContext() : base("PizzaRunnerContext")
        {
        }

        public DbSet<AccountModel> Accounts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}