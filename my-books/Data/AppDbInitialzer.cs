using my_books.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace my_books.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<AppDbContext>();

                if (!context.books.Any())
                {
                    context.books.AddRange(
                        new Book
                        {
                            Title = "1984",
                            Description = "A dystopian novel by George Orwell.",
                            Author = "George Orwell",
                            Genre = "Dystopian",
                            CoverUrl = "https://example.com/1984.jpg",
                            IsRead = true,
                            DateRead = DateTime.Now.AddDays(-20),
                            Rate = 5,
                            DateAdded = DateTime.Now.AddDays(-30)
                        },
                        new Book
                        {
                            Title = "To Kill a Mockingbird",
                            Description = "A novel about justice and inequality in the American South.",
                            Author = "Harper Lee",
                            Genre = "Classic",
                            CoverUrl = "https://example.com/mockingbird.jpg",
                            IsRead = true,
                            DateRead = DateTime.Now.AddDays(-15),
                            Rate = 4,
                            DateAdded = DateTime.Now.AddDays(-25)
                        },
                        new Book
                        {
                            Title = "The Great Gatsby",
                            Description = "A story of the Jazz Age and the American Dream.",
                            Author = "F. Scott Fitzgerald",
                            Genre = "Novel",
                            CoverUrl = "https://example.com/gatsby.jpg",
                            IsRead = false,
                            DateRead = null,
                            Rate = null,
                            DateAdded = DateTime.Now.AddDays(-10)
                        },
                        new Book
                        {
                            Title = "The Hobbit",
                            Description = "A fantasy adventure about Bilbo Baggins' journey.",
                            Author = "J.R.R. Tolkien",
                            Genre = "Fantasy",
                            CoverUrl = "https://example.com/hobbit.jpg",
                            IsRead = true,
                            DateRead = DateTime.Now.AddDays(-40),
                            Rate = 5,
                            DateAdded = DateTime.Now.AddDays(-50)
                        },
                        new Book
                        {
                            Title = "Sapiens: A Brief History of Humankind",
                            Description = "Explores the history and impact of Homo sapiens.",
                            Author = "Yuval Noah Harari",
                            Genre = "Non-fiction",
                            CoverUrl = "https://example.com/sapiens.jpg",
                            IsRead = false,
                            DateRead = null,
                            Rate = null,
                            DateAdded = DateTime.Now.AddDays(-5)
                        }
                    );

                    context.SaveChanges();
                }
            }
        }
    }
}
