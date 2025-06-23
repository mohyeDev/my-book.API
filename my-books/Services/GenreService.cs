using my_books.Data.Models;
using my_books.Data.Repositories;

namespace my_books.Services;

public class GenreService : IGenreService
{
    private readonly IGenreRepostiory _genre;

    public GenreService(IGenreRepostiory genre)
    {
        _genre = genre;
    }



    public Task<IEnumerable<Genre>> GetAllAsync() => _genre.GetAllAsync();

    public Task<Genre?> GetByIdAsync(int id) => _genre.GetByIdAsync(id);


    public Task AddAsync(Genre genre) => _genre.AddAsync(genre);

    public Task UpdateAsync(Genre genre) => _genre.UpdateAsync(genre);


    public Task DeleteAsync(Genre genre) => _genre.RemoveAsync(genre);

}