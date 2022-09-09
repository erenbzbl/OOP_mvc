using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

using YeniProje_OOP.Entity;

namespace YeniProje_OOP.Ornekler
{
    //Sınıfların içindeki ögekere erişim sağlamak için sınıftan bir nesne türetilir.
    //SınıfAdı nesne = new SınıfAdı();
    public class Class1
    {
        public void Topla()
        {
            int sayi1 = 10;
            int sayi2 = 20;
            int sonuc = sayi1 + sayi2;
            
        }
        void Carp()
        {
            int s1 = 10;
            int s2 = 20;
            int sonuc = s1 * s2;
        }
    }
} 

//ProductClass --> Sınıf class
//productClass --> Nesne object
