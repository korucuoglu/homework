using System.Collections.Generic;
using System.Threading.Tasks;
using BookStore.BookOperations.CreateBook;
using BookStore.BookOperations.GetBooks;
using BookStore.Models;

namespace BookStore.Service
{
    public interface IBookService<T> where T : class
    {
        Task<GetBooksQuery> GetByIdAsyc(int id);

        Task<List<GetBooksQuery>> GetAll();

        Task AddAsync(CreateBookCommand book);

        Task<T> Update(Book book);

        void DeleteById(int id);
        void Delete(Book book);

    }
}