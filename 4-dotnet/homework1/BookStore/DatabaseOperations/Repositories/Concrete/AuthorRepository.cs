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

    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {

        private readonly DataContext _context;
        public AuthorRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Author>> GetAllWithGenresAsync()
        {
            return await _context.Authors.Include(x => x.Books).ToListAsync();
        }

        public async Task<Author> GetFirstOrDefaultWithGenresAsync(int id)
        {
            return await _context.Authors.Include(x => x.Books).FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}