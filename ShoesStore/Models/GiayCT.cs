using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ShoesStore.Models
{
    public class GiayCT : DbContext 
    {
        public GiayCT() : base("ShoesStore")
        { }
        public DbSet<NSX> NSXs { get; set; }
        public DbSet<Giay> Giays { get; set; }
        public DbSet<GioHang> MuaHang { get; set; }

    }
}