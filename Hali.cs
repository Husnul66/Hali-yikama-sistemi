using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hali_yikama_fabrikasi
{
    internal class Hali
    {
        // Hali.cs
       
            public double Metrekare { get; set; }
            public DateTime AlimTarihi { get; set; }
            public DateTime TahminiTeslimTarihi { get; set; }
            public string Durum { get; set; } = "Yıkamada";

            public double Ucret => Metrekare * 20;
        }

    }

