﻿// <auto-generated />
using System;
using Domen;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Domen.Migrations
{
    [DbContext(typeof(CvecaraContext))]
    [Migration("20220910120457_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
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

                    b.Property<int?>("ProdajnoMestoId")
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

            modelBuilder.Entity("Domen.Osoba", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
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

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProizvodId");

                    b.ToTable("Proizvod");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Domen.Administrator", b =>
                {
                    b.HasBaseType("Domen.Osoba");

                    b.Property<DateTime>("DatumZaposlenja")
                        .HasColumnType("datetime2");

                    b.Property<int>("SifraZaposlednog")
                        .HasColumnType("int");

                    b.ToTable("Administrator");
                });

            modelBuilder.Entity("Domen.Kupac", b =>
                {
                    b.HasBaseType("Domen.Osoba");

                    b.Property<string>("BrojTelefona")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Kupac");
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

                    b.ToTable("Cvet");
                });

            modelBuilder.Entity("Domen.CvetniAranzman", b =>
                {
                    b.HasBaseType("Domen.Proizvod");

                    b.Property<int>("KupacId")
                        .HasColumnType("int");

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

                    b.HasIndex("KupacId");

                    b.HasIndex("PakovanjeId");

                    b.ToTable("CvetniAranzman");
                });

            modelBuilder.Entity("Domen.Dekoracija", b =>
                {
                    b.HasOne("Domen.Cvet", "Cvet")
                        .WithMany()
                        .HasForeignKey("CvetProizvodId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Domen.CvetniAranzman", "CvetniAranzman")
                        .WithMany("Dekoracije")
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
                        .OnDelete(DeleteBehavior.NoAction);

                    b.OwnsMany("Domen.Stavka", "Stavke", b1 =>
                        {
                            b1.Property<int>("NarudzbinaId")
                                .HasColumnType("int");

                            b1.Property<int>("StavkaId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<int>("Kolicina")
                                .HasColumnType("int");

                            b1.Property<int>("ProizvodId")
                                .HasColumnType("int");

                            b1.HasKey("NarudzbinaId", "StavkaId");

                            b1.HasIndex("ProizvodId");

                            b1.ToTable("Stavka");

                            b1.WithOwner("Narudzbina")
                                .HasForeignKey("NarudzbinaId");

                            b1.HasOne("Domen.Proizvod", "Proizvod")
                                .WithMany()
                                .HasForeignKey("ProizvodId")
                                .OnDelete(DeleteBehavior.Cascade)
                                .IsRequired();

                            b1.Navigation("Narudzbina");

                            b1.Navigation("Proizvod");
                        });

                    b.Navigation("Kupac");

                    b.Navigation("ProdajnoMesto");

                    b.Navigation("Stavke");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("Domen.Osoba", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("Domen.Osoba", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domen.Osoba", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("Domen.Osoba", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domen.Administrator", b =>
                {
                    b.HasOne("Domen.Osoba", null)
                        .WithOne()
                        .HasForeignKey("Domen.Administrator", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domen.Kupac", b =>
                {
                    b.HasOne("Domen.Osoba", null)
                        .WithOne()
                        .HasForeignKey("Domen.Kupac", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domen.Cvet", b =>
                {
                    b.HasOne("Domen.Proizvod", null)
                        .WithOne()
                        .HasForeignKey("Domen.Cvet", "ProizvodId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domen.CvetniAranzman", b =>
                {
                    b.HasOne("Domen.Kupac", "Kupac")
                        .WithMany()
                        .HasForeignKey("KupacId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Domen.Pakovanje", "Pakovanje")
                        .WithMany()
                        .HasForeignKey("PakovanjeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Domen.Proizvod", null)
                        .WithOne()
                        .HasForeignKey("Domen.CvetniAranzman", "ProizvodId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("Kupac");

                    b.Navigation("Pakovanje");
                });

            modelBuilder.Entity("Domen.CvetniAranzman", b =>
                {
                    b.Navigation("Dekoracije");
                });
#pragma warning restore 612, 618
        }
    }
}