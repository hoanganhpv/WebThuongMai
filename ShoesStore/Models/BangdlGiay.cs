using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ShoesStore.Models
{
    public class BangdlGiay : DropCreateDatabaseAlways<GiayCT>
    {
        protected override void Seed(GiayCT context)
        {
            GetNSXs().ForEach(c => context.NSXs.Add(c));
            GetGiays().ForEach(p => context.Giays.Add(p));
        }
        private static List<NSX> GetNSXs()
        {
            var nsxs= new List<NSX>
            {
                new NSX { MaNSX = 1, TenNSX = "Nikes" },
                new NSX { MaNSX = 2, TenNSX = "Vans" },
                new NSX { MaNSX = 3, TenNSX = "Adidas" }
            };
            return nsxs;
        }
        private static List<Giay> GetGiays()
        {
            var giays = new List<Giay>
            {                
                 
                new Giay
                {
                    MaGiay = 1,
                    TenGiay = "Nike Air Force 1 Type",
                    MoTa = "Street Style",
                    Hinhanh ="Pic1.jpg",
                    Gia = 3266000,
                    MaNSX = 1
                },               
                new Giay
                {
                    MaGiay = 2,
                    TenGiay = "Nike React Element 87",
                    MoTa = "Sport",
                    Hinhanh ="Pic2.jpg",
                    Gia = 3500000,
                    MaNSX = 2                 },
                               
                new Giay
                {
                    MaGiay = 3,
                    TenGiay = "Nike Air Max 2000",
                    MoTa = "Street Style",
                    Hinhanh ="Pic3.jpg",
                    Gia = 2540000,
                    MaNSX = 3
                },               
                new Giay
                {
                    MaGiay = 4,
                    TenGiay = "Nike Classic Cortez",
                    MoTa = "Sport",
                    Hinhanh ="Pic4.jpg",
                    Gia = 3640000,
                    MaNSX = 2
                },
                                 
                new Giay
                {
                    MaGiay = 5,
                    TenGiay = "Nike Legend React",
                    MoTa = "Sport",
                    Hinhanh ="Pic5.jpg",
                    Gia = 5250000,
                    MaNSX = 1
                },
                new Giay
                {
                    MaGiay = 6,
                    TenGiay = "Jordan Proto-Max 720",
                    MoTa = "Street Style",
                    Hinhanh ="Pic6.jpg",
                    Gia = 2599000,
                    MaNSX = 2
                },
                new Giay
                {
                    MaGiay = 7,
                    TenGiay = "Air Max 270 Bauhaus",
                    MoTa = "Sport",
                    Hinhanh ="Pic7.jpg",
                    Gia = 3240000,
                    MaNSX = 3
                },
                new Giay
                {
                    MaGiay = 8,
                    TenGiay = "Jordan Mars 270",
                    MoTa = "Street Style",
                    Hinhanh ="Pic8.jpg",
                    Gia= 2260000,
                    MaNSX = 2
                },
                new Giay
                {
                    MaGiay = 9,
                    TenGiay = "Nike Joom Fly",
                    MoTa = "Sport",
                    Hinhanh ="Pic9.jpg",
                    Gia = 4030000,
                    MaNSX = 1
                },
                new Giay
                {
                    MaGiay = 10,
                    TenGiay = "Jordan Trunner NTX",
                    MoTa = "Sport",
                    Hinhanh ="Pic10.jpg",
                    Gia = 3335000,
                    MaNSX = 2
                },
                new Giay
                {
                    MaGiay = 11,
                    TenGiay = "Nike Metcon Sport",
                    MoTa = "Street Style",
                    Hinhanh ="Pic11.jpg",
                    Gia = 2929000,
                    MaNSX = 3
                },


            };
            return giays;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override void InitializeDatabase(GiayCT context)
        {
            base.InitializeDatabase(context);
        }
    }
}