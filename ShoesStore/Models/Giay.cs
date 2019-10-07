using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace ShoesStore.Models
{
    public class Giay
    {
        [ScaffoldColumn(false)] public int MaGiay { get; set; }
        [Required, StringLength(100), Display(Name = "TenGiay")] public string TenGiay { get; set; }
        [Required, StringLength(1000), Display(Name = "MoTa"), DataType(DataType.MultilineText)] public string MoTa { get; set; }
        public string Hinhanh { get; set; }
        [Display(Name = "Gia")] public int? Gia { get; set; }
        public int? MaNSX { get; set; }
        public virtual NSX NSX { get; set; }
    }
}