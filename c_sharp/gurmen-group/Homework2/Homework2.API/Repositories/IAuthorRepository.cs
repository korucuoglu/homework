using Homework2.API.Dtos.Author;
using Homework2.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Homework2.API.Repositories
{
    public interface IAuthorRepository: IRepository<Author>
    {
        public Task<IEnumerable<AuthorBook>> GetAuthorByIdWithBook(int id);
        
    }
}
