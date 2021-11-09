using System.Collections.Generic;
using System.Threading.Tasks;
using BookStore.DatabaseOperations.Services.Abstract;
using BookStore.Models;
using BookStore.Shared;
using BookStore.ViewModels.Genre;

public interface IGenreService : IGenericService<Genre>
{
    Task<Response<List<GenreGetViewModel>>> GetAllWithBooks();
    Task<Response<GenreGetViewModel>> GetFirstWithBooks(int id);

}