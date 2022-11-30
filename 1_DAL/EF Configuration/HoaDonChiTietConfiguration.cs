﻿using _1_DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_DAL.EF_Configuration
{
    public class HoaDonChiTietConfiguration : IEntityTypeConfiguration<HoaDonChiTiet>
    {
        public void Configure(EntityTypeBuilder<HoaDonChiTiet> builder)
        {
            builder.ToTable("HoaDonChiTiet");
            builder.HasKey(x => x.Id);
            builder.HasOne<SanPham>(x => x.SanPham).WithMany(x => x.HoaDonChiTiet).HasForeignKey(x => x.IdSP);
            builder.HasOne<HoaDon>(x => x.HoaDon).WithMany(x => x.HoaDonChiTiet).HasForeignKey(x => x.IdHD);
            builder.Property(x => x.DonGia).IsRequired();
            builder.Property(x => x.SoLuong).IsRequired();
            builder.Property(x => x.TrangThai).IsRequired();
        }
    }
}
