using System;
using System.ComponentModel;
using SirketUygulamasi.Abstract;
namespace SirketUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCalisan projeYoneticisi = new ProjeYoneticisi
            {
                Ad = "Ahmet",
                Soyad = "Yılmaz",
                Departman = "Proje Yöneticisi"
            };


            BaseCalisan satisTemsilcisi = new SatisTemsilcisi
            {
                Ad = "Mehmet",
                Soyad = "Çakır",
                Departman = "Satış Temsilcisi"
            };

            BaseCalisan yazilimGelistiricisi = new YazilimGelistiricisi
            {
                Ad = "Kaya",
                Soyad = "Güner",
                Departman = "Yazılım Geliştiricisi"
            };
            
            projeYoneticisi.Gorev();
            satisTemsilcisi.Gorev();
            yazilimGelistiricisi.Gorev();

            projeYoneticisi.BilgileriYazdir();
            satisTemsilcisi .BilgileriYazdir();
            yazilimGelistiricisi.BilgileriYazdir();


        }
    }
}