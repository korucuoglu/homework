using System.Collections.Generic;
using System.Threading.Tasks;
using BookStore.Models;
using BookStore.Shared;
using BookStore.ViewModels.Author;
using BookStore.ViewModels.Books;

namespace BookStore.DatabaseOperations.Services.Abstract
{

    public interface IAuthorService : IGenericService<Author>
    {
        Task<Response<List<AuthorGetViewModelWithBooks>>> GetAllWithBooks();
        Task<Response<AuthorGetViewModelWithBooks>> GetWithBooks(int id);

    }

}