using System.Collections.Generic;
using System.Threading.Tasks;
using BookStore.Models;
using BookStore.Shared;
using BookStore.ViewModels;
using BookStore.ViewModels.Books;

namespace BookStore.Services
{
    public interface IGenericService<T> where T : class
    {
        Task<Response<T>> GetByIdAsyc(int id);

        Task<Response<List<T>>> GetAllAsync();

        Task<Response<NoContent>> AddAsync(T data);

        Task<Response<NoContent>> Update(T data);

        Response<NoContent> DeleteById(int id);
        Task<Response<NoContent>> Delete(T book);

    }
}