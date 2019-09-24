using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ShoesStore.Models
{
    public class BookDatabaseInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetBooks().ForEach(p => context.Books.Add(p));
        }
        private static List<Category> GetCategories()
        {
            var categories = new List<Category>
            {
                new Category { CategoryID = 1, CategoryName = "Nikes" },
                new Category { CategoryID = 2, CategoryName = "Vans" },
                new Category { CategoryID = 3, CategoryName = "Adidas" }
            };
            return categories;
        }
        private static List<Book> GetBooks()
        {
            var books = new List<Book>
            {                
                //book 1 
                new Book
                {
                    BookID = 1,
                    BookName = "Nike Air Force 1 Type",
                    Description = "Street Style",
                    ImagePath ="Pic1.jpg",
                    UnitPrice = 3266000.00f,
                    CategoryID = 1
                },
                //book 2                 
                new Book
                {
                    BookID = 2,
                    BookName = "Nike React Element 87",
                    Description = "Sport",
                    ImagePath ="Pic2.jpg",
                    UnitPrice = 3500000.00f,
                    CategoryID = 2                 },
                //book 3                 
                new Book
                {
                    BookID = 3,
                    BookName = "Nike Air Max 2000",
                    Description = "Street Style",
                    ImagePath ="Pic3.jpg",
                    UnitPrice = 2540000.00f,
                    CategoryID = 2
                },
                //book 4                 
                new Book
                {
                    BookID = 4,
                    BookName = "Nike Classic Cortez", 
                    Description = "Sport",
                    ImagePath ="Pic4.jpg",
                    UnitPrice = 3640000.00f,
                    CategoryID = 3
                },
                //book 5                 
                new Book
                {
                    BookID = 5,
                    BookName = "Nike Legend React",
                    Description = "Sport",
                    ImagePath ="Pic5.jpg",
                    UnitPrice = 5250000.00f,
                    CategoryID = 3
                },
                new Book
                {
                    BookID = 6,
                    BookName = "Jordan Proto-Max 720",
                    Description = "Sport",
                    ImagePath ="Pic6.jpg",
                    UnitPrice = 2599000.00f,
                    CategoryID = 3
                },
                new Book
                {
                    BookID = 7,
                    BookName = "Air Max 270 Bauhaus",
                    Description = "Sport",
                    ImagePath ="Pic7.jpg",
                    UnitPrice = 3240000.00f,
                    CategoryID = 3
                },
                new Book
                {
                    BookID = 8,
                    BookName = "Jordan Mars 270",
                    Description = "Sport",
                    ImagePath ="Pic8.jpg",
                    UnitPrice = 2260000.00f,
                    CategoryID = 3
                },
                new Book
                {
                    BookID = 9,
                    BookName = "Nike Joom Fly",
                    Description = "Sport",
                    ImagePath ="Pic9.jpg",
                    UnitPrice = 4030000.00f,
                    CategoryID = 3
                },
                new Book
                {
                    BookID = 10,
                    BookName = "Jordan Trunner NTX",
                    Description = "Sport",
                    ImagePath ="Pic10.jpg",
                    UnitPrice = 3335000.00f,
                    CategoryID = 3
                },
                new Book
                {
                    BookID = 11,
                    BookName = "Nike Metcon Sport",
                    Description = "Sport",
                    ImagePath ="Pic11.jpg",
                    UnitPrice = 2929000.00f,
                    CategoryID = 3
                },


            };
            return books;
        }
    }
}