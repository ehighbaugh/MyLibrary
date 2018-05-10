using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MyLibrary.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string Format { get; set; }
        [Display(Name = "Year Published")]
        public int? YearPublished { get; set; }
    }

    public class BookDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}