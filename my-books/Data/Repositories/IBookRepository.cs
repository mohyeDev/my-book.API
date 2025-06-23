using my_books.Data.Models;

namespace my_books.Data.Repositories
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAllAsync();
        Task<Book> GetByIdAsync(int Id);

        Task AddAsync(Book book);
        Task UpdateAsync(Book book);

        Task DeleteAsync(Book book);
    }
}
