using System.Collections.Generic;
using System.Threading.Tasks;
using BookStore.Models;

namespace BookStore.Service
{
    public interface IBookService<T> where T : class
    {
        Task<T> GetByIdAsyc(int id);

        Task<List<T>> GetAll();

        Task AddAsync(T data);

        Task<T> Update(T data);

        void DeleteById(int id);
        void Delete(T book);

    }
}