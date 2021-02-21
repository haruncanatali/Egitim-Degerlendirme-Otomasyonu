using Egitim.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Egitim.DataAccess.Concrete.EntityFramework.Mapping
{
    public class OkulYorumMap : IEntityTypeConfiguration<OkulYorum>
    {
        public void Configure(EntityTypeBuilder<OkulYorum> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).UseIdentityColumn();

            builder.Property(c => c.Ad).HasMaxLength(30).IsRequired();
            builder.Property(c => c.Soyad).HasMaxLength(30).IsRequired();
            builder.Property(c => c.Mail).HasMaxLength(100).IsRequired();
            builder.Property(c => c.YorumIcerik).HasMaxLength(1500).IsRequired();
            builder.Property(c => c.Puan).IsRequired();
            builder.Property(c => c.OkulId).IsRequired();

            builder.ToTable("OkulYorumlari");
            builder.Property(c => c.Id).HasColumnName("Id");
            builder.Property(c => c.Ad).HasColumnName("Ad");
            builder.Property(c => c.Soyad).HasColumnName("Soyad");
            builder.Property(c => c.Mail).HasColumnName("Mail");
            builder.Property(c => c.YorumIcerik).HasColumnName("YorumIcerik");
            builder.Property(c => c.Puan).HasColumnName("Puan");
            builder.Property(c => c.OkulId).HasColumnName("OkulId");
        }
    }
}
