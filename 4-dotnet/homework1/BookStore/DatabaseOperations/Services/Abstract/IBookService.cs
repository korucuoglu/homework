using System.Collections.Generic;
using System.Threading.Tasks;
using BookStore.Models;
using BookStore.Shared;
using BookStore.ViewModels.Books;

namespace BookStore.DatabaseOperations.Services.Abstract
{

    public interface IBookService : IGenericService<Book>
    {

        Task<Response<List<BookGetViewModel>>> GetAllWithGenresAsync();
        Task<Response<BookGetViewModel>> GetFirstOrDefaultWithGenresAsync(int id);

    }

}