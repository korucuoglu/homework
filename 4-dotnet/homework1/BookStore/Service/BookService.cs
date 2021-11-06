using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.BookOperations.Common;
using BookStore.BookOperations.CreateBook;
using BookStore.BookOperations.GetBooks;
using BookStore.Entity;
using BookStore.Models;
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
        public async Task AddAsync(CreateBookCommand data)
        {
            if (_context.Books.Any(x => x.Title == data.Title))
            {

                throw new InvalidOperationException("Kitap zaten mevcut");
            }

            Book book = new()
            {
                Title = data.Title,
                GenreId = data.GenreId,
                Publishdate = data.Publishdate,
                PageCount = data.PageCount
            };

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

        public async Task<List<GetBooksQuery>> GetAll()
        {
            return await _context.Books.Select(x => new GetBooksQuery
            {

                Title = x.Title,
                Genre = ((GenreEnum)x.GenreId).ToString(),
                PageCount = x.PageCount,
                Publishdate = x.Publishdate.Date.ToString("dd/mm/yyyy")



            }).ToListAsync();


        }

        public async Task<GetBooksQuery> GetByIdAsyc(int id)
        {
            return await _context.Books.Where(book => book.Id == id).Select(x => new GetBooksQuery
            {
                Title = x.Title,
                Genre = ((GenreEnum)x.GenreId).ToString(),
                PageCount = x.PageCount,
                Publishdate = x.Publishdate.Date.ToString("dd/mm/yyyy")



            }).FirstOrDefaultAsync();
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