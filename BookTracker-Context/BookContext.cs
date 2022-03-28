using BookTracker_Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace BookTracker_Context
{
    public class BookContext : DbContext 
    {
        public BookContext(DbContextOptions<BookContext> options)
            :base(options) 
        { }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookEdition> Editions { get; set; }
    }
}
