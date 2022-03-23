using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AutoMapper;
using BookStore.DatabaseOperations.Repositories.Abstract;
using BookStore.DatabaseOperations.Services.Abstract;
using BookStore.Shared;
using BookStore.ViewModels;

namespace BookStore.DatabaseOperations.Services.Concrete
{
    public class GenericService<TEntity> : IGenericService<TEntity> where TEntity : class
    {
        public readonly IRepository<TEntity> _repository;
        private readonly IMapper _mapper;

        public GenericService(IRepository<TEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public virtual async Task<Response<T>> AddAsync<T>(TEntity entity) where T : class
        {
            var data = _mapper.Map<T>(await _repository.AddAsync(entity));
            return Response<T>.Success(data, 201);

        }

        public async Task<Response<List<T>>> AddRangeAsync<T>(IEnumerable<TEntity> entities) where T : class
        {
            var data = _mapper.Map<List<T>>(await _repository.AddRangeAsync(entities));
            return Response<List<T>>.Success(data, 201);
        }

        public Response<NoContent> Remove(TEntity entity)
        {
            _repository.Remove(entity);
            return Response<NoContent>.Success(204);
        }

        public async Task<Response<List<T>>> GetAllAsync<T>() where T : class
        {
            var data = _mapper.Map<List<T>>(await _repository.GetAllAsync());
            return Response<List<T>>.Success(data, 200);
        }

        public async Task<Response<T>> GetByIdAsync<T>(int id) where T : class
        {
            var data = _mapper.Map<T>(await _repository.GetByIdAsync(id));
            return Response<T>.Success(data, 200);

        }

        public Response<NoContent> RemoveRange(IEnumerable<TEntity> entities)
        {
            _repository.RemoveRange(entities);
            return Response<NoContent>.Success(204);
        }

        public async Task<Response<T>> SingleOrDefaultAsync<T>(Expression<Func<TEntity, bool>> predicate) where T : class
        {
            var data = _mapper.Map<T>(await _repository.SingleOrDefaultAsync(predicate));
            return Response<T>.Success(data, 200);
        }

        public Response<NoContent> Update(TEntity entitiy)
        {
            _repository.Update(entitiy);
            return Response<NoContent>.Success(204);
        }

        public async Task<Response<IEnumerable<T>>> Where<T>(Expression<Func<TEntity, bool>> predicate) where T : class
        {
            var data = _mapper.Map<IEnumerable<T>>(await _repository.Where(predicate));
            return Response<IEnumerable<T>>.Success(data, 200);
        }

        public Response<NoContent> RemoveById(int id)
        {
            var data = _repository.GetByIdAsync(id).Result;

            if (data == null)
            {
                return Response<NoContent>.Fail("Böyle bir veri bulunamadı", 404);
            }


            _repository.Remove(data);
            return Response<NoContent>.Success(204);

        }
    }
}