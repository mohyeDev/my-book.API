namespace my_books.Data.Dto;

public class BookDto
{
    public int Id { get; set; } 
    public int? Rate { get; set; }   
    public bool IsRead { get; set; }    
    public string Title { get; set; }
    public string Author { get; set; }
    public string GenreName { get; set; }

}