using System.Collections.Generic;
using System.Threading.Tasks;
using BookStore.Models;
using BookStore.Shared;
using BookStore.ViewModels.Books;

namespace BookStore.DatabaseOperations.Repositories.Abstract
{

    public interface IBookRepository : IRepository<Book>
    {

        Task<List<Book>> GetAllWithGenresAsync();
        Task<Book> GetFirstOrDefaultWithGenresAsync(int id);

    }
}