using System.Collections.Generic;
using System.Threading.Tasks;
using BookStore.Models;

namespace BookStore.DatabaseOperations.Repositories.Abstract
{

    public interface IGenreRepository : IRepository<Genre>
    {

        Task<List<Genre>> GetAllWithBooks();
        Task<Genre> GetFirstWithBooks(int id);

    }
}