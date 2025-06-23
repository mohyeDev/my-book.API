using Microsoft.EntityFrameworkCore;
using my_books.Data.Models;

namespace my_books.Data.Repositories;

public class GenreRepository : IGenreRepostiory
{
    private readonly AppDbContext _context;

    public GenreRepository(AppDbContext context)
    {
        _context = context;
    }
    public async Task<IEnumerable<Genre>> GetAllAsync()
    {
        return await _context.genres.ToListAsync();
    }

    public async Task<Genre> GetByIdAsync(int id)
    {
        return await _context.genres.FindAsync(id);
    }

    public async Task AddAsync(Genre genre)
    {
         await _context.genres.AddAsync(genre);
         await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Genre genre)
    {
         _context.genres.Update(genre);
        await _context.SaveChangesAsync();
    }

    public async Task RemoveAsync(Genre genre)
    {
        _context.genres.Remove(genre);
        await _context.SaveChangesAsync();
    }
}