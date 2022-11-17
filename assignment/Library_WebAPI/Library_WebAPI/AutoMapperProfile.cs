using AutoMapper;
using Library_WebAPI.Dtos;
using Library_WebAPI.Models;

namespace Library_WebAPI
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Book, GetBookDto>();
            CreateMap<AddBookDto, Book>();
            CreateMap<UpdateBookDto, Book>();
        }
    }
}
