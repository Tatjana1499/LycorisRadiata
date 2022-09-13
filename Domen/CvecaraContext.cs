using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class CvecaraContext : IdentityDbContext<Osoba, IdentityRole<int>, int>
    {
        public CvecaraContext([NotNull] DbContextOptions options) : base(options)
        {
        }

        public DbSet<Cvet> Cvet { get; set; }
        public DbSet<CvetniAranzman> CvetniAranzman { get; set; }
        public DbSet<Kupac> Kupac { get; set; }
        public DbSet<Narudzbina> Narudzbina { get; set; }
        public DbSet<Pakovanje> Pakovanje { get; set; }
        public DbSet<ProdajnoMesto> ProdajnoMesto { get; set; }
        public DbSet<Proizvod> Proizvod { get; set; }
        public DbSet<Stavka> Stavka { get; set; }
        public DbSet<Dekoracija> Dekoracija { get; set; }
        public DbSet<Osoba> Osoba { get; set; }
        public DbSet<Administrator> Administrator { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          //  optionsBuilder.UseSqlServer(@"");
            optionsBuilder.LogTo(Console.WriteLine);
            optionsBuilder.EnableSensitiveDataLogging(true);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Narudzbina>().HasOne(n => n.Kupac).WithMany().OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Dekoracija>().HasKey(d => new { d.CvetProizvodId, d.CvetniAranzmanProizvodId });
            modelBuilder.Entity<Dekoracija>().HasOne(d => d.Cvet).WithMany().HasForeignKey(d => d.CvetProizvodId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Dekoracija>().HasOne(d => d.CvetniAranzman).WithMany(cv => cv.Dekoracije).HasForeignKey(d => d.CvetniAranzmanProizvodId).OnDelete(DeleteBehavior.NoAction);
            

            modelBuilder.Entity<Cvet>().HasBaseType<Proizvod>().ToTable("Cvet");
            modelBuilder.Entity<CvetniAranzman>().HasBaseType<Proizvod>().ToTable("CvetniAranzman");

            modelBuilder.Entity<Kupac>().HasBaseType<Osoba>().ToTable("Kupac");
            modelBuilder.Entity<Administrator>().HasBaseType<Osoba>().ToTable("Administrator");

            modelBuilder.Entity<Narudzbina>().OwnsMany(n => n.Stavke).WithOwner(s => s.Narudzbina);

            modelBuilder.Entity<CvetniAranzman>().HasOne(ca => ca.Pakovanje).WithMany().OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Narudzbina>().HasOne(n => n.ProdajnoMesto).WithMany().IsRequired(false).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<CvetniAranzman>().HasOne(ca => ca.Kupac).WithMany().OnDelete(DeleteBehavior.NoAction);

            base.OnModelCreating(modelBuilder);

        }
    }
}
