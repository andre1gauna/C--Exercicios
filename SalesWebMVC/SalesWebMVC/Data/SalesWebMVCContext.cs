using Microsoft.EntityFrameworkCore;
using SalesWebMVC.ModelMap;
using SalesWebMVC.Models;
using SalesWebMVC.Models.Enums;
namespace SalesWebMVC.Data
{
    public class SalesWebMVCContext : DbContext
    {
        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=INSPIRON\SQLEXPRESS;Database=SalesWebMVC;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
        public SalesWebMVCContext(DbContextOptions<SalesWebMVCContext> options)
         : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DepartmentMap());
            modelBuilder.ApplyConfiguration(new SalesRecordMap());
            modelBuilder.ApplyConfiguration(new SellerMap());
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
