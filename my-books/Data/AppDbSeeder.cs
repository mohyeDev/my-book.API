using my_books.Data.Models;

namespace my_books.Data;

public class AppDbSeeder
{
    public async static void Seed(IApplicationBuilder app)
    {
        using (var scope = app.ApplicationServices.CreateScope())
        {
            var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            if (!context.genres.Any())
            {
                context.genres.AddRange(
                    new Genre { Name = "Fantasy" },
                    new Genre { Name = "Classic" },
                    new Genre { Name = "Dystopian" },
                    new Genre { Name = "Non-fiction" },
                    new Genre { Name = "Novel" }
                    );

                await context.SaveChangesAsync();
            }

            if (!context.books.Any())
            {
                var genres = context.genres.ToList();
                
                context.books.AddRange(
                    new Book
                    {
                        Title = "1984",
                        Author = "George Orwell",
                        Description = "A dystopian novel.",
                        CoverUrl = "https://example.com/1984.jpg",
                        IsRead = true,
                        DateRead = DateTime.Now.AddDays(-20),
                        Rate = 5,
                        DateAdded = DateTime.Now.AddDays(-30),
                        GenreId = genres.First(g => g.Name == "Dystopian").Id
                    },
                    new Book
                    {
                        Title = "To Kill a Mockingbird",
                        Author = "Harper Lee",
                        Description = "A novel about justice and racism.",
                        CoverUrl = "https://example.com/mockingbird.jpg",
                        IsRead = true,
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        DateAdded = DateTime.Now.AddDays(-25),
                        GenreId = genres.First(g => g.Name == "Classic").Id
                    },
                    new Book
                    {
                        Title = "The Hobbit",
                        Author = "J.R.R. Tolkien",
                        Description = "A fantasy adventure.",
                        CoverUrl = "https://example.com/hobbit.jpg",
                        IsRead = false,
                        DateRead = null,
                        Rate = null,
                        DateAdded = DateTime.Now.AddDays(-15),
                        GenreId = genres.First(g => g.Name == "Fantasy").Id
                    }
                );

                await context.SaveChangesAsync();

            }
        }
    }
}