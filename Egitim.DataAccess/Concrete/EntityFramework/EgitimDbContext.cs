using Egitim.DataAccess.Concrete.EntityFramework.Mapping;
using Egitim.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Egitim.DataAccess.Concrete.EntityFramework
{
    public class EgitimDbContext:DbContext
    {
        private const string ConnectionString = @"Server=DESKTOP-SL1S3RQ\SQLEXPRESS;Database=DboEgitimDegerlendirme;Trusted_Connection=True;MultipleActiveResultSets=true";

        public EgitimDbContext(DbContextOptions<EgitimDbContext> options):base(options)
        {

        }

        public DbSet<Okul> Okul { get; set; }
        public DbSet<Ogretmen> Ogretmen { get; set; }
        public DbSet<OkulYorum> OkulYorum { get; set; }
        public DbSet<OgretmenYorum> OgretmenYorum { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Relationships
            modelBuilder.Entity<Okul>().HasMany(c => c.Ogretmenler).WithOne(c => c.Okulu).HasForeignKey(c => c.OkulId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Okul>().HasMany(c => c.Yorumlar).WithOne(c => c.Okulu).HasForeignKey(c => c.OkulId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Ogretmen>().HasMany(c => c.Yorumlar).WithOne(c => c.Ogretmeni).HasForeignKey(c => c.OgretmenId).OnDelete(DeleteBehavior.Cascade);

            //mapping
            modelBuilder.ApplyConfiguration(new OkulMap());
            modelBuilder.ApplyConfiguration(new OgretmenMap());
            modelBuilder.ApplyConfiguration(new OkulYorumMap());
            modelBuilder.ApplyConfiguration(new OgretmenYorumMap());
        }
    }
}
