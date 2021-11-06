using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookStore.Entity;
using BookStore.Models;
using BookStore.Shared;
using BookStore.ViewModels;
using BookStore.ViewModels.Books;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Service
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        private readonly DataContext _context;
        private readonly DbSet<T> _table;
        public GenericService(DataContext context, IMapper mapper)
        {
            _context = context;
            _table = _context.Set<T>();

        }

        public async Task<Response<List<T>>> GetAllAsync()
        {
            // return Response<List<T>>.Success(await _table.ToListAsync(), 200);

            var data = await _table.ToListAsync();

            return Response<List<T>>.Success(data, 200);

        }

        public async Task<Response<T>> GetByIdAsyc(int id)
        {
            var data = await _table.FindAsync(id);
            return Response<T>.Success(data, 200);
        }

        public async Task<Response<NoContent>> AddAsync(T data)
        {
            await _table.AddAsync(data);
            await _context.SaveChangesAsync();
            return Response<NoContent>.Success(200);
        }

        public async Task<Response<NoContent>> Delete(T data)
        {
            _table.Remove(data);
            await _context.SaveChangesAsync();
            return Response<NoContent>.Success(200);
        }

        public Response<NoContent> DeleteById(int id)
        {
            var data = _table.Find(id);

            _table.Remove(data);
            _context.SaveChanges();
            return Response<NoContent>.Success(200);
        }
        public async Task<Response<NoContent>> Update(T data)
        {
            _context.Entry(data).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Response<NoContent>.Success(200);


        }
    }
}