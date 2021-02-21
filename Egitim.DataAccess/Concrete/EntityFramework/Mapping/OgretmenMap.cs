using Egitim.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Egitim.DataAccess.Concrete.EntityFramework.Mapping
{
    public class OgretmenMap : IEntityTypeConfiguration<Ogretmen>
    {
        public void Configure(EntityTypeBuilder<Ogretmen> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).UseIdentityColumn();

            builder.Property(c => c.OgretmenAdSoyad).HasMaxLength(61).IsRequired();
            builder.Property(c => c.OgretmenBrans).HasMaxLength(100).IsRequired();
            builder.Property(c => c.OgretmenAciklama).HasMaxLength(5000).IsRequired();
            builder.Property(c => c.OgretmenPuan).IsRequired();
            builder.Property(c => c.FotoBaglantisi).HasMaxLength(500).IsRequired();
            builder.Property(c => c.OgretmenPozisyon).HasMaxLength(100).IsRequired();
            builder.Property(c => c.OkulId).IsRequired();

            builder.ToTable("Ogretmenler");
            builder.Property(c => c.Id).HasColumnName("Id");
            builder.Property(c => c.OgretmenAdSoyad).HasColumnName("OgretmenAdSoyad");
            builder.Property(c => c.OgretmenBrans).HasColumnName("OgretmenBrans");
            builder.Property(c => c.OgretmenAciklama).HasColumnName("OgretmenAciklama");
            builder.Property(c => c.OgretmenPuan).HasColumnName("OgretmenPuan");
            builder.Property(c => c.FotoBaglantisi).HasColumnName("FotoBaglantisi");
            builder.Property(c => c.OgretmenPozisyon).HasColumnName("OgretmenPozisyon");
            builder.Property(c => c.OkulId).HasColumnName("OkulId");
        }
    }
}
