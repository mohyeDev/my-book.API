using AutoMapper;
using my_books.Data.Dto;
using my_books.Data.Models;

namespace my_books.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {

        CreateMap<Book, BookDto>().ForMember(dest => dest.GenreName, opt => opt.MapFrom(src => src.Genre.Name));
        CreateMap<Book, CreateBookDto>().ReverseMap();
    }
}