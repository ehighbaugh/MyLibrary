using MyLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MyLibrary
{
    public class LibraryDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }

   
}