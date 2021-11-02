using BA_SOLID.ISP.Good;
using BA_SOLID.LSP.Bad;
using BA_SOLID.LSP.Good;
using BA_SOLID.OCP.Good.Abstract;
using BA_SOLID.OCP.Good.Concrete;
using BA_SOLID.SRP.Good;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            #region SRP
            /* SOLID S - Single-responsiblity principle : Bir sınıf (nesne) yalnızca bir amaç uğruna değiştirilebilir, o da o sınıfa yüklenen sorumluluktur, yani bir sınıfın(fonksiyona da indirgenebilir) yapması gereken yalnızca bir işi olması gerekir. */
            Console.WriteLine(
                new GoodEmployeeProcessor().
                InsertEmployee(
                    new SRP.Entity.Employee() {
                Id = 1,
                FirstName = "Güney",
                LastName = "Balcı",
                HireDate = DateTime.Now
            
            })?"Başarılı" : "Hata Oluştu");

            #endregion

            #region OCP
            /* SOLID O — Open-closed principle: Bir sınıf ya da fonksiyon halihazırda var olan özellikleri korumalı ve değişikliğe izin vermemelidir. Yani davranışını değiştirmiyor olmalı ve yeni özellikler kazanabiliyor olmalıdır. */

            GoodCoffee kahve1 = new Latte();
            GoodCoffee kahve2 = new Americano();

            var deger = kahve2.FiyatHesapla(40);
            Console.WriteLine("Kahve fiyatı : " + kahve1.FiyatHesapla(20));

            #endregion

            #region LSP
            /* SOLID L — Liskov substitution principle: Kodlarımızda herhangi bir değişiklik yapmaya gerek duymadan alt sınıfları, türedikleri(üst) sınıfların yerine kullanabilmeliyiz.Child class üst sınıfı karşılayabilmelidir. */
            #region Bad

            BadRentangle badRentangle = new BadRentangle();
            badRentangle.Width = 2;
            badRentangle.Height = 3;
            if (BadCalculate.HesaplaArea(badRentangle) != 6)
            {
                Console.WriteLine("BadRentagle alan hesaplaması yanlıştır");
            }

            BadSquare badSquare = new BadSquare();
            badSquare.Height = 3;
            if (BadCalculate.HesaplaArea(badSquare) != 9)
            {
                Console.WriteLine("BadSquare alan hesaplaması yanlıştır");
            }

            // 24 ' den farklı bir  veri var ise hata alıyoruz demektir. BadSquare Class 'ı ile new'leme işlemi yapıyoruz. Child Class'lar Parent Class lar ile karşılanabilmelidir. Child class'ın üst class'a veri gönderebilir.
            BadRentangle newRentangle = new BadSquare();
            newRentangle.Height = 4;
            newRentangle.Width = 6;
            if (BadCalculate.HesaplaArea(newRentangle) != 6)
            {
                Console.WriteLine("BadRentangle yeni alan hesaplaması yanlıştır");
            }

            #endregion

            #region Good
            Rectangle kare = new Rectangle();
            kare.Width = 2;
            kare.Height = 3;
            if (kare.Hesapla() != 6)
            {
                Console.WriteLine("Dikdörtgen alan hesaplama yanlış.");
            }

            Square square = new Square();
            square.Width = 4;
            if (square.Hesapla() != 16)
            {
                Console.WriteLine("Square alan hesaplama yanlış.");
            }


            #endregion

            #endregion

            #region ISP
            /* SOLID I — Interface segregation principle: Sorumlulukların hepsini tek bir arayüze toplamak yerine daha özelleştirilmiş birden fazla arayüz oluşturmalıyız. Her kuş canlıdır; ancak her kuş uçamaz örneği söylenebilir. 
             ! Inferface zorunlulukdur. Ve içerisindeki her şey doldurulmalıdır. Bu yüzden thrownotimlemenpexception döndürülür. 
             */

            // IDisposible Pattern uygulanır ve bu interface implement edilir using ile içerisine implement edilmişler. scope bittiğinde garbage collector'a göndericektir. Çünkü C# memory management değildir.
            Personal p = new Personal();
            p.AdSoyad = "Güney Balcı";
            using (Personal test = new Personal())
            {
                test.Dispose();
            }
            #endregion

            #region DIP
            /* SOLID D — Dependency Inversion Principle: Sınıflar arası bağımlılıklar olabildiğince az olmalıdır özellikle üst seviye sınıflar alt seviye sınıflara bağımlı olmamalıdır.*/
            #endregion


            Console.ReadKey();
        }
    }
}
