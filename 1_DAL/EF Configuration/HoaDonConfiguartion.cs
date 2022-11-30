using _1_DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_DAL.EF_Configuration
{
    public class HoaDonConfiguartion:IEntityTypeConfiguration<HoaDon>
    {
        public void Configure(EntityTypeBuilder<HoaDon> builder)
    {
            builder.ToTable("HoaDon");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.MaHD).HasMaxLength(10).IsRequired();
            builder.HasOne<KhachHang>(x => x.KhachHang)
                .WithMany(x => x.HoaDon).HasForeignKey(x => x.IdKH);
            builder.HasOne<NhanVien>(x => x.NhanVien)
                .WithMany(x => x.HoaDon).HasForeignKey(x => x.IdNV);

            builder.Property(x => x.TrangThai).HasDefaultValue(0);

            builder.HasCheckConstraint("PriceSum", "TongTien >= 0")
                   .Property(x => x.TongTien)
                   .IsRequired();
            builder.Property(x => x.NgayTao)
                  .IsRequired();
            builder.Property(x => x.NgayThanhToan).HasDefaultValueSql("GETDATE()");
        }
}
}
//public Guid Id { get; set; }
//public Guid IdKH { get; set; }
//public Guid IdNV { get; set; }
//public string MaHD { get; set; }
////public string MaNV { get; set; }
//public DateTime NgayTao { get; set; }
//public DateTime NgayThanhToan { get; set; }
//public double TongTien { get; set; }
//public int SoDiemSD { get; set; }
//public int SoTienQuyDoi { get; set; }
//public string TrangThai { get; set; }
