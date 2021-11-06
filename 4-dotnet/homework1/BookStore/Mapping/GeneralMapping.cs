using AutoMapper;
using BookStore.Models;
using BookStore.ViewModels.Books;

namespace BookStore.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Book, CreateBookViewModel>().ReverseMap();
            CreateMap<Book, GetBookViewModel>().ReverseMap();
            CreateMap<Book, UpdateBookViewModel>().ReverseMap();
        }
    }
}