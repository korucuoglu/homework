using System.Collections.Generic;
using System.Threading.Tasks;
using BookStore.DatabaseOperations.Repositories.Abstract;
using BookStore.Entity;
using BookStore.Models;
using BookStore.Shared;
using BookStore.ViewModels.Books;
using Microsoft.EntityFrameworkCore;

namespace BookStore.DatabaseOperations.Repositories.Concrete
{

    public class BookRepository : Repository<Book>, IBookRepository
    {

        private readonly DataContext _context;
        public BookRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Book>> GetAllWithGenresAsync()
        {
            return await _context.Books.Include(x => x.Genre).ToListAsync();
        }

        public async Task<Book> GetFirstOrDefaultWithGenresAsync(int id)
        {
            return await _context.Books.Include(x => x.Genre).FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}