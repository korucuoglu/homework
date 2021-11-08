using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using BookStore.Models;
using BookStore.Shared;
using BookStore.ViewModels;
using BookStore.ViewModels.Books;

namespace BookStore.DatabaseOperations.Services.Abstract
{
    public interface IGenericService<TEntity> where TEntity : class
    {
        Task<Response<T>> GetByIdAsync<T>(int id) where T : class;

        Task<Response<List<T>>> GetAllAsync<T>() where T : class;

        Task<Response<IEnumerable<T>>> Where<T>(Expression<Func<TEntity, bool>> predicate) where T : class;

        Task<Response<T>> SingleOrDefaultAsync<T>(Expression<Func<TEntity, bool>> predicate) where T : class;

        Task<Response<T>> AddAsync<T>(TEntity entity) where T : class;

        Task<Response<List<T>>> AddRangeAsync<T>(IEnumerable<TEntity> entities) where T : class;

        Response<NoContent> Remove(TEntity entity);
        Response<NoContent> RemoveById(int id);

        Response<NoContent> RemoveRange(IEnumerable<TEntity> entities);

        Response<NoContent> Update(TEntity entitiy);

    }
}