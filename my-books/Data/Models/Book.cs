﻿namespace my_books.Data.Models
{
    public class Book
    {
        public int Id { get; set; } 
        public int? Rate { get; set; }   
        public bool IsRead { get; set; }    
        public string Title { get; set; }
        public string Author { get; set; }  
        public string CoverUrl { get; set; }    
        public string Description { get; set; } 
        public DateTime? DateRead { get; set; }  
        public DateTime DateAdded { get; set; } 

        public int GenreId { get; set; }
        public Genre Genre { get; set; }    
    } 
}
