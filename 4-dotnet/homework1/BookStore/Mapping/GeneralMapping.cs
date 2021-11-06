using System.Collections.Generic;
using AutoMapper;
using BookStore.Models;
using BookStore.Shared;
using BookStore.ViewModels.Books;

namespace BookStore.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {

            CreateMap<Book, GetBookViewModel>().ReverseMap();
            CreateMap<Book, CreateBookViewModel>().ReverseMap();
            CreateMap<Book, UpdateBookViewModel>().ReverseMap();


            CreateMap<Response<Book>, Response<GetBookViewModel>>().ReverseMap();
            CreateMap<Response<List<Book>>, Response<List<GetBookViewModel>>>().ReverseMap();







        }
    }
}