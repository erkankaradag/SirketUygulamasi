using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirketUygulamasi.Abstract
{
    internal class ProjeYoneticisi : BaseCalisan
    {
        public override void Gorev()
        {
            Console.WriteLine("Proje Yöneticisi olarak çalışıyorum.");
        }
    }
}
