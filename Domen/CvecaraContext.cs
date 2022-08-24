using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class CvecaraContext : DbContext
    {
        public DbSet<Cvet> Cvet { get; set; }
        public DbSet<CvetniAranzman> CvetniAranzman { get; set; }
        public DbSet<Kupac> Kupac { get; set; }
        public DbSet<Narudzbina> Narudzbina { get; set; }
        public DbSet<Pakovanje> Pakovanje { get; set; }
        public DbSet<ProdajnoMesto> ProdajnoMesto { get; set; }
        public DbSet<Proizvod> Proizvod { get; set; }
        public DbSet<Stavka> Stavka { get; set; }
        public DbSet<Dekoracija> Dekoracija { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=LycorisRadiata; Trusted_Connection=True;");
            optionsBuilder.LogTo(Console.WriteLine);
            optionsBuilder.EnableSensitiveDataLogging(true);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Narudzbina>().HasOne(n => n.Kupac).WithMany().OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Dekoracija>().HasKey(d => new { d.CvetProizvodId, d.CvetniAranzmanProizvodId });
            modelBuilder.Entity<Dekoracija>().HasOne(d => d.Cvet).WithMany().HasForeignKey(d => d.CvetProizvodId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Dekoracija>().HasOne(d => d.CvetniAranzman).WithMany().HasForeignKey(d => d.CvetniAranzmanProizvodId).OnDelete(DeleteBehavior.NoAction);
            

            modelBuilder.Entity<Cvet>().HasBaseType<Proizvod>().ToTable("Cvet");
            modelBuilder.Entity<CvetniAranzman>().HasBaseType<Proizvod>().ToTable("CvetniAranzman");

            modelBuilder.Entity<Narudzbina>().OwnsMany(n => n.Stavke).WithOwner(s => s.Narudzbina);

            modelBuilder.Entity<CvetniAranzman>().HasOne(ca => ca.Pakovanje).WithMany();
            modelBuilder.Entity<Narudzbina>().HasOne(n => n.ProdajnoMesto).WithMany().IsRequired(false);

           
        }
    }
}
