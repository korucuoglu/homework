using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Entity;
using BookStore.Models;
using BookStore.ViewModels.Books;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Service
{
    public class BookService : IBookService<Book>
    {
        private readonly DataContext _context;
        public BookService(DataContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Book book)
        {
            if (_context.Books.Any(x => x.Title == book.Title))
            {

                throw new InvalidOperationException("Kitap zaten mevcut");
            }

            await _context.AddAsync(book);
            _context.SaveChanges();

        }
        public async void DeleteById(int id)
        {
            var data = _context.Books.Find(id);
            _context.Books.Remove(data);
            await _context.SaveChangesAsync();
        }

        public void Delete(Book book)
        {
            _context.Books.Remove(book);
        }

        public async Task<List<Book>> GetAll()
        {
            return await _context.Books.ToListAsync();


        }

        public async Task<Book> GetByIdAsyc(int id)
        {
            return await _context.Books.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Book> Update(Book updateModel)
        {
            var data = _context.Books.Find(updateModel.Id);
            data.Title = updateModel.Title != default ? updateModel.Title : data.Title;
            data.GenreId = updateModel.GenreId != default ? updateModel.GenreId : data.GenreId;
            data.PageCount = updateModel.PageCount != default ? updateModel.PageCount : data.PageCount;
            data.Publishdate = updateModel.Publishdate != default ? updateModel.Publishdate : data.Publishdate;

            await _context.SaveChangesAsync();

            return data;
        }
    }
}