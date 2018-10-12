using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ConsoleApp1
{
    public class UrunContext : DbContext


    {
        public UrunContext():base("urunConnection")
        {

        }



       //Veritabanında olmasını istediğin şemyı burada yaparız.

        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Urun> Urunler { get; set; }


    }
}