using my_books.Data.Models;

namespace my_books.Services;

public interface IGenreService
{
    Task<IEnumerable<Genre>> GetAllAsync();
    Task<Genre?> GetByIdAsync(int id);
    Task AddAsync(Genre genre);
    Task UpdateAsync(Genre genre);
    Task DeleteAsync(Genre genre);
}