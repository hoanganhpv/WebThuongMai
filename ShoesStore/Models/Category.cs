using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace ShoesStore.Models
{
    public class Category
    {
        [ScaffoldColumn(false)] public int CategoryID { get; set; }
        [Required, StringLength(100), Display(Name = "Name")] public string CategoryName { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}