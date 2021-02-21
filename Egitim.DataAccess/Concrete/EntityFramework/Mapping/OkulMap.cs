using Egitim.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Egitim.DataAccess.Concrete.EntityFramework.Mapping
{
    public class OkulMap : IEntityTypeConfiguration<Okul>
    {
        public void Configure(EntityTypeBuilder<Okul> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).UseIdentityColumn();

            builder.Property(c => c.OkulAdi).HasMaxLength(150).IsRequired();
            builder.Property(c => c.OkulAciklama).HasMaxLength(5000).IsRequired();
            builder.Property(c => c.OkulPuan).IsRequired();
            builder.Property(c => c.FotoBaglantisi).HasMaxLength(500).IsRequired();

            builder.ToTable("Okullar");
            builder.Property(c => c.Id).HasColumnName("Id");
            builder.Property(c => c.OkulAdi).HasColumnName("OkulAdi");
            builder.Property(c => c.OkulAciklama).HasColumnName("OkulAciklama");
            builder.Property(c => c.OkulPuan).HasColumnName("OkulPuan");
            builder.Property(c => c.FotoBaglantisi).HasColumnName("FotoBaglantisi");
        }
    }
}
