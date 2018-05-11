namespace MyLibrary.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using MyLibrary.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<MyLibrary.Models.BookDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MyLibrary.Models.BookDbContext context)
        {
            context.Books.AddOrUpdate(x => x.BookId,
        new Book()
        {
            BookId = 1,
            Title = "Pride and Prejudice",
            YearPublished = 1813,
            Author = "Jane Austen",
            Genre = "Novel of Manners"
        },
        new Book()
        {
            BookId = 2,
            Title = "Northanger Abbey",
            YearPublished = 1817,
            Author = "Jane Austen",
            Genre = "Gothic parody"
        },
        new Book()
        {
            BookId = 3,
            Title = "David Copperfield",
            YearPublished = 1850,
            Author = "Charles Dickens",
            Genre = "Bildungsroman"
        },
        new Book()
        {
            BookId = 4,
            Title = "Don Quixote",
            YearPublished = 1617,
            Author = "Miguel de Cervantes",
            Genre = "Picaresque"
        }
        );
        }
    }
}
