using System.Collections.Generic;
using System.Threading.Tasks;
using BookStore.DatabaseOperations.Services.Abstract;
using BookStore.Models;
using BookStore.Shared;
using BookStore.ViewModels.Genre;

public interface IGenreService : IGenericService<Genre>
{
    Task<Response<List<GenreGetViewModelWithBooks>>> GetAllWithBooks();
    Task<Response<GenreGetViewModelWithBooks>> GetFirstWithBooks(int id);

}