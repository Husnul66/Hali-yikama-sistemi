using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hali_yikama_fabrikasi
{
    internal class Musteri
    {
        Hali hali = new Hali();
        // Musteri.cs
      
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public string Telefon { get; set; }
            public string Adres { get; set; }
            public List<Hali> Halilar { get; set; } = new List<Hali>();
        }

    }

