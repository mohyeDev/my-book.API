using Microsoft.EntityFrameworkCore;
using my_books.Data.Models;

namespace my_books.Data.Repositories
{
    public class BookRepository : IBookRepository
    {

        private readonly AppDbContext _context;

        public BookRepository(AppDbContext context)
        {
            _context = context;
        }


        public Task AddAsync(Book book)
        {
            _context.books.AddAsync(book);
            return _context.SaveChangesAsync();  
        }   

        public Task DeleteAsync(Book book)
        {
              _context.books.Remove(book);
            return _context.SaveChangesAsync();             
        }

        public async Task<IEnumerable<Book>> GetAllAsync()
        {
            return await _context.books.Include(b => b.Genre).ToListAsync();
        }

        public async Task<Book> GetByIdAsync(int Id)
        {
            return await _context.books.Include(b=>b.Genre).FirstOrDefaultAsync(b=>b.Id == Id); ;
        }

        public Task UpdateAsync(Book book)
        {
            _context.books.Update(book);
            return _context.SaveChangesAsync();
        }
    }
}
