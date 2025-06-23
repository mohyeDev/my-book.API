using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using my_books.Data.Dto;
using my_books.Data.Models;
using my_books.Services;

namespace my_books.Controllers;

[ApiController]
[Route("api")]
public class BookController  : ControllerBase
{

    private readonly IBookService _bookService;
    private readonly IMapper _mapper;

    public BookController(IBookService bookService , IMapper mapper)
    {
        _bookService = bookService;
        _mapper = mapper; 
    }


    [HttpGet]
    public async Task<IActionResult> GetAllBooks()
    {
        var books = await _bookService.GetAllBooksAsync();
        var bookDto = _mapper.Map<IEnumerable<BookDto>>(books);
        return Ok(bookDto);

    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetBookById(int id)
    {
        var book = await _bookService.GetBookByIdAsync(id);
        if (book is null)
        {
            return NotFound("No Book Found");
        }
        var bookDto = _mapper.Map<BookDto>(book);
        return Ok(book);
    }

    [HttpPost]

    public async Task<IActionResult> AddBook([FromBody] CreateBookDto dto)
    {
        var book = _mapper.Map<Book>(dto);
        book.DateAdded = DateTime.Now;
        await _bookService.AddBookAsync(book);
        var loadedBook =await _bookService.GetBookByIdAsync(book.Id);
        var resultDto = _mapper.Map<BookDto>(loadedBook);
        return CreatedAtAction(nameof(GetBookById), new { id = book.Id }, resultDto);
    }

    [HttpPut("{id:int}")]

    public async Task<IActionResult> UpdateBook(int id, [FromBody] CreateBookDto dto)
    {
        var existing = await _bookService.GetBookByIdAsync(id);
        if (existing is null)
        {
            return NotFound("No Book Fond With this Id!");
        }

        _mapper.Map(dto, existing);
        await _bookService.UpdateBookAsync(existing);
        return NoContent();
    }


    [HttpDelete("{id:int}")]

    public async Task<IActionResult> DeleteBook(int id)
    {
        var book = await _bookService.GetBookByIdAsync(id);
        if (book is null)
        {
            return NotFound("No Book With this Id!");
        }

        await _bookService.DeleteBookAsync(book);
        return NoContent();
    }
    
}
    
    
    
