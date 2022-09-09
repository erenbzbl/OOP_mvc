using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

using Microsoft.AspNetCore.Mvc;
using YeniProje_OOP.Ornekler;

namespace YeniProje_OOP.Controllers
{
    public class DefaultController : Controller
    {
        //void islemler()
        // {
        //     //Class1 c = new Class1();
        //     //{
        //     //    c.Topla();
        //     //}
        void mesajlar()
        {
            ViewBag.m1 = "Merhaba bu bir core projesi";
            ViewBag.m2 = "Merhaba proje çok iyi duruyor";
            ViewBag.m3 = "Selamlar, hi, hello, bonjour";
        }

        int topla()
        {
            int s1 = 20;
            int s2 = 30;
            int sonuc = s1 + s2;
            return sonuc;
        }

        int Cevre()
        {
            int kisa = 10;
            int uzun = 20;
            int sonuc = 2 * (kisa + uzun);
            return sonuc;
        }

        int faktoriyel(int p)
        {
            int f = 1;
            for (int i = 1; i <= p; i++)
            {
                f = f * i;
            }
            return f;
        }

        string cumle()
        {
            string c = "Küçük hanımlar küçük beyler sizler hepiniz geleceğin birer gülü, parlayan, ışık saçan yıldızı olacaksınız.";
            return c;
        }

        void MesajListesi(string p)
        {
            ViewBag.v = p;
        }

        void Kullanici(string username)
        {
            ViewBag.v = username;
            
        }

        int Topla(int sayi1, int sayi2)
        {
           int sonuc = sayi1 + sayi2;
            return sonuc;

        }


        public IActionResult deneme()
        {
            Sehirler sehirler = new Sehirler();
            sehirler.Ad = "Kiev";
            sehirler.SehirID = 1;
            sehirler.Nufus = 10000;
            sehirler.ulke = "Ukrayna";
            sehirler.Renk1 = "Mavi";
            sehirler.Renk2 = "Sarı";
            ViewBag.v1 = sehirler.SehirID;
            ViewBag.v2 = sehirler.ulke;
            ViewBag.v3 = sehirler.Ad;  
            ViewBag.v4 = sehirler.Nufus;
            ViewBag.v5 = sehirler.Renk1;
            ViewBag.v6 = sehirler.Renk2;
            ViewBag.v7 = sehirler.Renk3;


            sehirler.Ad = "Üsküp";
            sehirler.SehirID = 2;
            sehirler.Nufus = 5000;
            sehirler.ulke = "Makedonya";
            sehirler.Renk1 = "Kırmızı";
            sehirler.Renk2 = "Sarı";
            sehirler.Renk3 = "";
            ViewBag.z1 = sehirler.SehirID;
            ViewBag.z2 = sehirler.ulke;
            ViewBag.z3 = sehirler.Ad;
            ViewBag.z4 = sehirler.Nufus;
            ViewBag.z5 = sehirler.Renk1;
            ViewBag.z6 = sehirler.Renk2;
            ViewBag.z7 = sehirler.Renk3;

            return View();
        }


        public IActionResult Index()
        {
            mesajlar();
            MesajListesi("Parametre ismi");
            Kullanici("Üye");
            ViewBag.tp = Topla(2, 4);
            return View();
        }

        public IActionResult Urunler()
        {
            mesajlar();
            ViewBag.t = topla();
            ViewBag.c = Cevre();
            ViewBag.faktor = faktoriyel(6);
            Kullanici("Member000");
            return View();
        }
        public IActionResult Customer()
        {
            Kullanici("Admin1234");
            ViewBag.c = cumle();
            return View();
        }
    }
}

