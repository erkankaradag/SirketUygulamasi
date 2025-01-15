using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirketUygulamasi.Abstract
{
    internal abstract class BaseCalisan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Departman { get; set; }

        // Abstract metod: Her çalışan pozisyonuna göre özelleştirilecek
        public abstract void Gorev();

        //Ortak metot
        public void BilgileriYazdir()
        {
            Console.WriteLine($"Adı ve Soyadı: {Ad} {Soyad}, Departman:{Departman}");
        }

    }
}
