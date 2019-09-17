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
                    BookName = "Nike 1",
                    Description = "Street Style",
                    ImagePath ="Pic1.jpg",
                    UnitPrice = 16.04f,
                    CategoryID = 1
                },
                //book 2                 
                new Book
                {
                    BookID = 2,
                    BookName = "Nike 2",
                    Description = "Sport",
                    ImagePath ="Pic2.jpg",
                    UnitPrice = 19.60f,
                    CategoryID = 2                 },
                //book 3                 
                new Book
                {
                    BookID = 3,
                    BookName = "Nike 3",
                    Description = "Street Style",
                    ImagePath ="Pic3.jpg",
                    UnitPrice = 26.73f,
                    CategoryID = 2
                },
                //book 4                 
                new Book
                {
                    BookID = 4,
                    BookName = "Nike 4", 
                    Description = "Sport",
                    ImagePath ="Pic4.jpg",
                    UnitPrice = 23.79f,
                    CategoryID = 3
                },
                //book 5                 
                new Book
                {
                    BookID = 5,
                    BookName = "Nike 4",
                    Description = "Sport",
                    ImagePath ="Pic5.jpg",
                    UnitPrice = 16.04f,
                    CategoryID = 3
                }, 


            };
            return books;
        }
    }
}