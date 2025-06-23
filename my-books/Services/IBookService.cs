using my_books.Data.Models;

namespace my_books.Services;

public interface IBookService
{
    Task<IEnumerable<Book>> GetAllBooksAsync();

    Task<Book?> GetBookByIdAsync(int id);

    Task AddBookAsync(Book book);
    Task UpdateBookAsync(Book book);
    Task DeleteBookAsync(Book book);


}