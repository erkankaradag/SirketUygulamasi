# Şirket Uygulaması - C# ile Abstract Sınıf Kullanımı

Bu proje, bir şirketin çalışanlarını temsil eden bir uygulamaya odaklanmaktadır. Her çalışanın ortak özellikleri ve davranışları tanımlanırken, her pozisyonun kendine özgü davranışları özelleştirilmektedir.

---

## Proje Yapısı

### 1. **Abstract Sınıf: `BaseCalisan`**
`BaseCalisan`, tüm çalışanlar için ortak olan özellikleri ve davranışları tanımlar. Bu sınıf soyut bir sınıf olduğundan, içerdiği `Gorev` metodu tüm alt sınıfları tarafından uygulanmak zorundadır.

#### Ortak Özellikler:
- **Ad**: Çalışanın adı
- **Soyad**: Çalışanın soyadı
- **Departman**: Çalışanın bağlı olduğu departman

#### Ortak Davranışlar:
- **`Gorev()`**: Her çalışanın pozisyonuna özgü davranışların tanımlanacağı abstract bir metot.
- **`BilgileriYazdir()`**: Çalışan bilgilerini konsola yazdırır.

---

### 2. **Alt Sınıflar**
Her pozisyon (Proje Yöneticisi, Satış Temsilcisi, Yazılım Geliştiricisi) için birer sınıf oluşturulur. Bu sınıflar, `BaseCalisan` sınıfından tüm özellikleri miras alır ve `Gorev` metodunu kendi davranışlarına göre uygular.

#### Proje Yöneticisi:
```csharp
public class ProjeYoneticisi : BaseCalisan
{
    public override void Gorev()
    {
        Console.WriteLine("Proje yöneticisi olarak çalışıyorum.");
    }
}
```

#### Satış Temsilcisi:
```csharp
public class SatisTemsilcisi : BaseCalisan
{
    public override void Gorev()
    {
        Console.WriteLine("Satış temsilcisi olarak çalışıyorum.");
    }
}
```

#### Yazılım Geliştiricisi:
```csharp
public class YazilimGelistiricisi : BaseCalisan
{
    public override void Gorev()
    {
        Console.WriteLine("Yazılım geliştirici olarak çalışıyorum.");
    }
}
```

---

### 3. **Program.cs**
Ana uygulama, farklı pozisyonlarda çalışanları tanımlar ve bu çalışanların özelliklerini ve davranışlarını test eder.

#### Kod:
```csharp
using System;
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
            satisTemsilcisi.BilgileriYazdir();
            yazilimGelistiricisi.BilgileriYazdir();
        }
    }
}
```

---

## Projeyi Çalıştırma
1. **Gerekli Araçlar:**
   - .NET SDK (C# derleyicisi)
   - Bir IDE (Visual Studio veya Visual Studio Code önerilir)

2. **Adımlar:**
   - Projeyi bir klasöre kopyalayın.
   - Komut satırından projeyi derleyin ve çalıştırın:
     ```bash
     dotnet run
     ```

3. **Beklenen Çıktı:**
   ```plaintext
   Proje yöneticisi olarak çalışıyorum.
   Satış temsilcisi olarak çalışıyorum.
   Yazılım geliştirici olarak çalışıyorum.
   Ad: Ahmet, Soyad: Yılmaz, Departman: Proje Yöneticisi
   Ad: Mehmet, Soyad: Çakır, Departman: Satış Temsilcisi
   Ad: Kaya, Soyad: Güner, Departman: Yazılım Geliştiricisi
   ```

---

## Anahtar Kavramlar
- **Abstract Sınıflar:** Ortak davranışları tanımlamak için kullanılır. Alt sınıflar bu davranışları kendi için uygular.
- **Polimorfizm:** Üst sınıf türünden bir referans ile alt sınıf nesnelerini çağırma.
- **Override:** Abstract metotları alt sınıflarda özelleştirme.

---

Bu uygulama, nesneye yönelik programlamanın (OOP) temellerini anlamanızı kolaylaştırmak amacıyla hazırlanmıştır.

