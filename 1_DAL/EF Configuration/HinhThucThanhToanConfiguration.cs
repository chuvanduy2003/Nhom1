using _1_DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_DAL.EF_Configuration
{
    public class HinhThucThanhToanConfiguration : IEntityTypeConfiguration<HinhThucThanhToan> 
    {
        public void Configure(EntityTypeBuilder<HinhThucThanhToan> builder)
        {
            builder.ToTable("HinhThucThanhToan");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Ma).HasMaxLength(10).IsRequired();
            //builder.HasOne<NhanVien>(x => x.NhanVien).WithMany(x => x.HinhThucThanhToan).HasForeignKey(x => x.IdNV);
            builder.HasOne<HoaDon>(x => x.HoaDon).WithMany(x => x.HinhThucThanhToan).HasForeignKey(x => x.IdHD);
            builder.Property(x=>x.LoaiHinhThanhToan).HasMaxLength(100).IsUnicode().IsRequired();
            builder.HasCheckConstraint("PriceSumtt", "TongTienThanhToan >= 0")
                   .Property(x => x.TongTienThanhToan)
                   .IsRequired();
            builder.Property(x => x.TrangThai).HasDefaultValue(0);

            
        }
    }
}
