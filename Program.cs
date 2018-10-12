using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Güncelleme işlemleri
            //LINQ (language integrated Query)
            UrunContext context = new UrunContext();

            var urun = context.Urunler.Find(1);

            urun.Fiyat = urun.Fiyat + (urun.Fiyat* 0.5);
            urun.UrunAdi = "Samsung s4";
            urun.StokAdeti = urun.StokAdeti + 100;

            context.SaveChanges();

            urun = context.Urunler.Find(1);

            Console.WriteLine("uru id :{0} urun adı : {1} fiyat : {2}", urun.Id, urun.UrunAdi, urun.Fiyat);


            Console.ReadLine();

                
           



        }
    }
}
