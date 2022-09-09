using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace YeniProje_OOP.Ornekler
{
    public class Sehirler : Bayrak
    {
        public  int SehirID { get; set; }
        public string? Ad { get; set; }
        public int Nufus { get; set; }
        public  string? ulke { get; set; }
    }
}
