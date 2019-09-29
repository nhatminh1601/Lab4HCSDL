using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TenancyManagement.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        { }
        public DbSet<QuanLy> QuanLy { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<ChuNha> ChuNha { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<LoaiNha> LoaiNha { get; set; }
        public DbSet<Nha> Nha { get; set; }
        public DbSet<PhanCong> PhanCong { get; set; }
        public DbSet<ChiNhanh> ChiNhanh { get; set; }
        public DbSet<LichXemNha> LichXemNha { get; set; }
        public DbSet<HopDong> HopDong { get; set; }
        public DbSet<BanKyKet> BanKyKet { get; set; }
        public DbSet<YeuCau> YeuCau { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BanKyKet>().HasKey(k => new { k.ContractId, k.CustomerId, k.EmployeeId });
            modelBuilder.Entity<LichXemNha>().HasKey(k => new { k.CustomerId, k.HomeId });
            modelBuilder.Entity<PhanCong>().HasKey(k => new { k.BranchId, k.EmployeeId });
            modelBuilder.Entity<YeuCau>().HasKey(k => new { k.CategoryHomeId, k.CustomerId });
            modelBuilder.Entity<QuanLy>().HasKey(k => new { k.BranchId, k.EmployeeId, k.HomeId });

        }

    }
}
