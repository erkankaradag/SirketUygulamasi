using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirketUygulamasi.Abstract
{
    internal class SatisTemsilcisi : BaseCalisan
    {
        public override void Gorev()
        {
            Console.WriteLine("Satış Temsilcisi olarak çalışıyorum.");
        }
    }
}
