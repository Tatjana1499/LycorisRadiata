﻿using Domen;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            using CvecaraContext context = new CvecaraContext();

            //Kupac k = new Kupac
            //{
            //    BrojTelefona = "0648578649",
            //    Email = "bailovict@gmail.com",
            //    Ime = "Tatjana",
            //    Prezime = "Bailovic",
            //    KorisnickoIme = "taca",
            //    Lozinka = "taca1234"
            //};

            //context.Kupac.Add(k);
            //context.SaveChanges();

            //List<Kupac> kupci = context.Kupac.Where(k => k.KupacId == 1).ToList();
            //Console.WriteLine(kupci.First());

            //ProdajnoMesto pm1 = new ProdajnoMesto
            //{
            //    Adresa = "Dostava",
            //    Slika = "",
            //    Sajt = "",
            //    RadnoVreme = ""
            //};
            //ProdajnoMesto pm2 = new ProdajnoMesto
            //{
            //    Adresa = "Kneza Mihaila 66",
            //    Slika = "slika1",
            //    Sajt = "www.facebook.com",
            //    RadnoVreme = "8:00-20:00"
            //};
            //context.ProdajnoMesto.Add(pm1);
            //context.ProdajnoMesto.Add(pm2);
            //context.SaveChanges();

            //Narudzbina n = new Narudzbina
            //{
            //    KupacId = 2,
            //    Adresa = "Momcila Kaplara 3",
            //    StatusIsporuke = StatusIsporuke.Obrada,
            //    VrstaNarudzbine = VrstaNarudzbine.Dostava,
            //    ProdajnoMestoId = pm1.ProdajnoMestoId
            //};

            //context.Narudzbina.Add(n);
            //context.SaveChanges();

            //Proizvod p1 = new Proizvod
            //{
            //    Naziv = "proizvod 1",
            //    Cena = 100
            //};
            //Proizvod p2 = new Proizvod
            //{
            //    Naziv = "proizvod 2",
            //    Cena = 200
            //};
            //Proizvod p3 = new Proizvod
            //{
            //    Naziv = "proizvod 3",
            //    Cena = 300
            //};

            //context.Proizvod.Add(p1);
            //context.Proizvod.Add(p2);
            //context.Proizvod.Add(p3);
            //context.SaveChanges();

            //Stavka s1 = new Stavka
            //{
            //    Kolicina = 10,
            //    ProizvodId = 1,
            //    NarudzbinaId = 8
            //};
            //Stavka s2 = new Stavka
            //{
            //    Kolicina = 1,
            //    ProizvodId = 2,
            //    NarudzbinaId = 8
            //};
            //Stavka s3 = new Stavka
            //{
            //    Kolicina = 5,
            //    ProizvodId = 3,
            //    NarudzbinaId = 8
            //};
            //Narudzbina nar = context.Narudzbina.Single(n => n.NarudzbinaId == 8);
            //nar.Stavke.Add(s1);
            //nar.Stavke.Add(s2);
            //nar.Stavke.Add(s3);
            //context.SaveChanges();

            //Narudzbina nar =  context.Narudzbina.Single(n => n.NarudzbinaId == 8);
            //Console.WriteLine(nar);

            //Cvet c = new Cvet()
            //{
            //    Naziv = "Bela rada",
            //    Boja = Boja.Bela,
            //    Cena = 300,
            //    Familija = Familija.Aktinidijevke,
            //    Opis = "Opis123",
            //    Slika = "slika2"
            //};
            //context.Cvet.Add(c);
            //context.SaveChanges();

            //Pakovanje pak = new Pakovanje
            //{
            //    Boja = Boja.Bela,
            //    Cena = 500,
            //    Materijal = Materijal.Plastika,
            //    Oblik = Oblik.Srce,
            //    Naziv = "Pakovanje1",
            //    Slika = "slika123"
            //};
            //context.Pakovanje.Add(pak);
            //context.SaveChanges();

            //CvetniAranzman ca = new CvetniAranzman()
            //{
            //    Cena = 1000+pak.Cena,
            //    Naziv = "Buket ruza",
            //    Masna = true,
            //    Sjaj = Sjaj.Srebrni,
            //    Namena = Namena.Rodjendan,
            //    Napomena = "Srecan ti rodjendan",
            //    PakovanjeId = pak.PakovanjeId

            //};
            //context.CvetniAranzman.Add(ca);
            //context.SaveChanges();

            //Dekoracija d1 = new Dekoracija
            //{
            //    BrojCvetova = 5,
            //    CvetProizvodId = 4,
            //    CvetniAranzmanProizvodId = 6
            //};
            //Dekoracija d2 = new Dekoracija
            //{
            //    BrojCvetova = 2,
            //    CvetProizvodId = 7,
            //    CvetniAranzmanProizvodId = 6
            //};
            //context.Dekoracija.Add(d1);
            //context.Dekoracija.Add(d2);
            //context.SaveChanges();

           // CvetniAranzman cvAr =  context.CvetniAranzman.Single(cs => cs.ProizvodId == 6);
           // List<Dekoracija> parovi = context.Dekoracija.Where(d => d.CvetniAranzmanProizvodId == 6).ToList();
           // List<Cvet> cvece = new List<Cvet>();
           // foreach (Dekoracija dek in parovi)
           // {
           //     Cvet cvet = context.Cvet.Single(c => c.ProizvodId == dek.CvetProizvodId);
           //     cvece.Add(cvet);
           // }
           //// cvece.ForEach(Console.WriteLine);
           // int i = 0;
           // foreach(Cvet c in cvece)
           // {
           //     Console.WriteLine(c + $"   kolicina: {parovi[i].BrojCvetova}");
           //     i++;
           // }

        }
    }
}
