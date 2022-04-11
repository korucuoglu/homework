using Homework2.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Homework2.API.Repositories
{
    public interface IAuthorRepository
    {
        Task<List<Author>> GetAll();
        Task<Author> GetById(int id);

        Task<int> Save(Author model);

        Task<bool> Update(Author model);

        Task<bool> Delete(int id);
        Task<bool> Any(int id);
    }
}
