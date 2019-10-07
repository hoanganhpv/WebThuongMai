using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ShoesStore.Models
{
    public class NSX
    {

        [ScaffoldColumn(false)] public int MaNSX { get; set; }
        [Required, StringLength(100), Display(Name = "Name")] public string TenNSX{ get; set; }
        public virtual ICollection<Giay> Giays { get; set; }
    }
}