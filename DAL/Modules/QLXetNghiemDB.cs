using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL.Modules
{
    public partial class QLXetNghiemDB : DbContext
    {
        public QLXetNghiemDB()
            : base("name=QLXetNghiemDB")
        {
        }

        public virtual DbSet<CONGTY> CONGTY { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIEN { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CONGTY>()
                .HasMany(e => e.NHANVIEN)
                .WithRequired(e => e.CONGTY)
                .WillCascadeOnDelete(false);
        }
    }
}
