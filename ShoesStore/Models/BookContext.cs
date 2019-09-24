using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ShoesStore.Models
{
    public class BookContext : DbContext
    {
        public BookContext() : base("ShoesStore") { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }
    }
}