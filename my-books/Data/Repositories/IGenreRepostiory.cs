using my_books.Data.Models;

namespace my_books.Data.Repositories;

public interface IGenreRepostiory
{
    Task<IEnumerable<Genre>> GetAllAsync();
    Task<Genre> GetByIdAsync(int id);
    Task AddAsync(Genre genre);
    Task UpdateAsync(Genre genre);
    Task RemoveAsync(Genre genre);
    
    


}