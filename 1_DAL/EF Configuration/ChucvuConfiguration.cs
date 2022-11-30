using _1_DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_DAL.EF_Configuration
{
    public class ChucvuConfiguration : IEntityTypeConfiguration<chucvu>
    {
        public void Configure(EntityTypeBuilder<chucvu> builder)
        {
            builder.ToTable("chucvu");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Ma).HasMaxLength(10).IsRequired();
            builder.Property(x => x.Ten).HasMaxLength(50).IsRequired()
                   .IsUnicode();
        }
    }
}
