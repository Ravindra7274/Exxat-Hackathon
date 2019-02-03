using Exxat.SupportPro.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Exxat.SupportPro.API.ModelContext
{
    public class ModelContext:DbContext
    {
        protected string ConnectionString;
        public ModelContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }
        public ModelContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptions)
        {
            if (!string.IsNullOrEmpty(ConnectionString))
                dbContextOptions.UseSqlServer(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        
        //public DbSet<SupportToolModel> SupportToolModels { get; set; }
        public DbSet<Module> Module { get; set; }
        public DbSet<CommonQuery> CommonQueries { get; set; }
        //public DbSet<Troubleshoot> Troubleshoots { get; set; }
    }
}
