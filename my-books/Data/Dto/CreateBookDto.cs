namespace my_books.Data.Dto;

public class CreateBookDto
{
    public string Title { get; set; }
    public string Author { get; set; }  
    public string CoverUrl { get; set; }    
    public string Description { get; set; } 
    public int? Rate { get; set; }   
    public bool IsRead { get; set; }    
    public DateTime? DateRead { get; set; }
    public int GenreId { get; set; }

}