﻿// <auto-generated />
using Domen;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Domen.Migrations
{
    [DbContext(typeof(CvecaraContext))]
    [Migration("20220822151944_dodataDekoracija")]
    partial class dodataDekoracija
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domen.Dekoracija", b =>
                {
                    b.Property<int>("CvetProizvodId")
                        .HasColumnType("int");

                    b.Property<int>("CvetniAranzmanProizvodId")
                        .HasColumnType("int");

                    b.Property<int>("BrojCvetova")
                        .HasColumnType("int");

                    b.HasKey("CvetProizvodId", "CvetniAranzmanProizvodId");

                    b.HasIndex("CvetniAranzmanProizvodId");

                    b.ToTable("Dekoracija");
                });

            modelBuilder.Entity("Domen.Kupac", b =>
                {
                    b.Property<int>("KupacId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrojTelefona")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KorisnickoIme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lozinka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KupacId");

                    b.ToTable("Kupac");
                });

            modelBuilder.Entity("Domen.Narudzbina", b =>
                {
                    b.Property<int>("NarudzbinaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KupacId")
                        .HasColumnType("int");

                    b.Property<int>("ProdajnoMestoId")
                        .HasColumnType("int");

                    b.Property<int>("StatusIsporuke")
                        .HasColumnType("int");

                    b.Property<int>("VrstaNarudzbine")
                        .HasColumnType("int");

                    b.HasKey("NarudzbinaId");

                    b.HasIndex("KupacId");

                    b.HasIndex("ProdajnoMestoId");

                    b.ToTable("Narudzbina");
                });

            modelBuilder.Entity("Domen.Pakovanje", b =>
                {
                    b.Property<int>("PakovanjeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Boja")
                        .HasColumnType("int");

                    b.Property<decimal>("Cena")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Materijal")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Oblik")
                        .HasColumnType("int");

                    b.Property<string>("Slika")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PakovanjeId");

                    b.ToTable("Pakovanje");
                });

            modelBuilder.Entity("Domen.ProdajnoMesto", b =>
                {
                    b.Property<int>("ProdajnoMestoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RadnoVreme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sajt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slika")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProdajnoMestoId");

                    b.ToTable("ProdajnoMesto");
                });

            modelBuilder.Entity("Domen.Proizvod", b =>
                {
                    b.Property<int>("ProizvodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Cena")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProizvodId");

                    b.ToTable("Proizvod");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Proizvod");
                });

            modelBuilder.Entity("Domen.Stavka", b =>
                {
                    b.Property<int>("NarudzbinaId")
                        .HasColumnType("int");

                    b.Property<int>("RedniBroj")
                        .HasColumnType("int");

                    b.Property<int>("Kolicina")
                        .HasColumnType("int");

                    b.Property<int>("ProizvodId")
                        .HasColumnType("int");

                    b.HasKey("NarudzbinaId", "RedniBroj");

                    b.HasIndex("ProizvodId");

                    b.ToTable("Stavka");
                });

            modelBuilder.Entity("Domen.Cvet", b =>
                {
                    b.HasBaseType("Domen.Proizvod");

                    b.Property<int>("Boja")
                        .HasColumnType("int");

                    b.Property<int>("Familija")
                        .HasColumnType("int");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slika")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Cvet");
                });

            modelBuilder.Entity("Domen.CvetniAranzman", b =>
                {
                    b.HasBaseType("Domen.Proizvod");

                    b.Property<bool>("Masna")
                        .HasColumnType("bit");

                    b.Property<int>("Namena")
                        .HasColumnType("int");

                    b.Property<string>("Napomena")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PakovanjeId")
                        .HasColumnType("int");

                    b.Property<int>("Sjaj")
                        .HasColumnType("int");

                    b.HasIndex("PakovanjeId");

                    b.HasDiscriminator().HasValue("CvetniAranzman");
                });

            modelBuilder.Entity("Domen.Dekoracija", b =>
                {
                    b.HasOne("Domen.Cvet", "Cvet")
                        .WithMany()
                        .HasForeignKey("CvetProizvodId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Domen.CvetniAranzman", "CvetniAranzman")
                        .WithMany()
                        .HasForeignKey("CvetniAranzmanProizvodId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Cvet");

                    b.Navigation("CvetniAranzman");
                });

            modelBuilder.Entity("Domen.Narudzbina", b =>
                {
                    b.HasOne("Domen.Kupac", "Kupac")
                        .WithMany()
                        .HasForeignKey("KupacId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Domen.ProdajnoMesto", "ProdajnoMesto")
                        .WithMany()
                        .HasForeignKey("ProdajnoMestoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kupac");

                    b.Navigation("ProdajnoMesto");
                });

            modelBuilder.Entity("Domen.Stavka", b =>
                {
                    b.HasOne("Domen.Narudzbina", "Narudzbina")
                        .WithMany()
                        .HasForeignKey("NarudzbinaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domen.Proizvod", "Proizvod")
                        .WithMany()
                        .HasForeignKey("ProizvodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Narudzbina");

                    b.Navigation("Proizvod");
                });

            modelBuilder.Entity("Domen.CvetniAranzman", b =>
                {
                    b.HasOne("Domen.Pakovanje", "Pakovanje")
                        .WithMany()
                        .HasForeignKey("PakovanjeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pakovanje");
                });
#pragma warning restore 612, 618
        }
    }
}
