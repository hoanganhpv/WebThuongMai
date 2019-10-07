using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ShoesStore.Models
{
    public class GioHang
    {
        [Key]
        public string MaHang { get; set; }
        public string MaGiohang { get; set; }
        public int SoLuong { get; set; }
        public System.DateTime DateCreated { get; set; }
        public int MaGiay { get; set; }
        public virtual Giay Giay { get; set; }
    }
}