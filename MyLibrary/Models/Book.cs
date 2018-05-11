using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyLibrary.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required, MaxLength(100, ErrorMessage ="Title must be less than 100 characters")]
        public string Title { get; set; }
        [Required, MaxLength(100, ErrorMessage = "Author must be less than 100 characters")]
        public string Author { get; set; }
        public string Genre { get; set; }
        public string Format { get; set; }
        public string Publisher { get; set; }
        [Display(Name = "Year Published")]
        public int? YearPublished { get; set; }
    }
}
