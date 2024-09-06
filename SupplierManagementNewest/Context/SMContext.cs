using Microsoft.EntityFrameworkCore;
using SupplierManagementNewest.Entities;


namespace SupplierManagement.Context
{
    public class SMContext : DbContext
    {
        public SMContext(DbContextOptions<SMContext> options) : base(options)
        {

        }
        public DbSet<tb_Supplier> tb_Suppliers { get; set; }
        public DbSet<tb_Personel> tb_Personel { get; set; }
    }
}

