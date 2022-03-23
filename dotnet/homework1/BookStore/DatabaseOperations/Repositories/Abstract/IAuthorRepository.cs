using System.Collections.Generic;
using System.Threading.Tasks;
using BookStore.Models;

namespace BookStore.DatabaseOperations.Repositories.Abstract
{

    public interface IAuthorRepository : IRepository<Author>
    {

        Task<List<Author>> GetAllWithGenresAsync();
        Task<Author> GetFirstOrDefaultWithGenresAsync(int id);


    }


}