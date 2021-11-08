using System.Collections.Generic;
using AutoMapper;
using BookStore.Models;
using BookStore.Shared;
using BookStore.ViewModels.Books;
using BookStore.ViewModels.Genre;

namespace BookStore.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {


            #region Book

            CreateMap<Book, BookGetViewModel>().ForMember(dest => dest.Genre, opt => opt.MapFrom(src => src.Genre.Name));

            CreateMap<BookCreateViewModel, Book>();
            CreateMap<BookUpdateViewModel, Book>();

            #endregion

            #region Genre 

            CreateMap<Genre, GenreGetViewModel>();
            CreateMap<GenreCreateViewModel, Genre>();
            CreateMap<GenreUpdateViewModel, Genre>();


            #endregion







        }
    }
}