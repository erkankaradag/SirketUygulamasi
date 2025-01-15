using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirketUygulamasi.Abstract
{
    internal class YazilimGelistiricisi : BaseCalisan
    {
        public override void Gorev()
        {
            Console.WriteLine("Yazılım Geliştiricisi olarak çalışıyorum.");
        }
    }
}
