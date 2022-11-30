using _1_DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_DAL.EF_Configuration
{
    public class NSXConfiguartion : IEntityTypeConfiguration<NhaSanXuat>
    {
        public void Configure(EntityTypeBuilder<NhaSanXuat> builder)
        {
            builder.ToTable("NhaSanXuat");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Ma).HasMaxLength(10).IsRequired();
            builder.Property(x => x.NoiSX).HasMaxLength(100).IsRequired().IsUnicode();
            builder.Property(x => x.TrangThai).HasDefaultValue(0);
        }
    }
}
