using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BillObject.Models
{
    public partial class BillManagermentContext : DbContext
    {
        public BillManagermentContext()
        {
        }

        public BillManagermentContext(DbContextOptions<BillManagermentContext> options)
            : base(options)
        {
        }

        public virtual DbSet<KhachHang> KhachHangs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(local);Uid=sa;Pwd=123;Database=BillManagerment");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.MaKh);

                entity.ToTable("KhachHang");

                entity.Property(e => e.HoTenKh)
                    .HasMaxLength(50)
                    .HasColumnName("HoTenKH");

                entity.Property(e => e.LoaiKh).HasColumnName("DiaChi");
                entity.Property(e => e.LoaiKh).HasColumnName("LoaiKH");

                entity.Property(e => e.MaKh).HasColumnName("MaKH");

                entity.Property(e => e.QuocTich).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
