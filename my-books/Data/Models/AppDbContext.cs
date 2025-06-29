﻿using Microsoft.EntityFrameworkCore;

namespace my_books.Data.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) :base(options)
        {
            
        }

        public DbSet<Book> books { get; set; }  

        public DbSet<User> users { get; set; }  

        public DbSet<Genre> genres { get; set; }
    }
}
