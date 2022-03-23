using System.Collections.Generic;
using System.Threading.Tasks;
using BookStore.DatabaseOperations.Repositories.Abstract;
using BookStore.Entity;
using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.DatabaseOperations.Repositories.Concrete
{

    public class GenreRepository : Repository<Genre>, IGenreRepository
    {
        private readonly DataContext _context;
        public GenreRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Genre>> GetAllWithBooks()
        {
            return await _context.Genres.Include(x => x.Books).ToListAsync();
        }

        public async Task<Genre> GetFirstWithBooks(int id)
        {
            return await _context.Genres.Include(x => x.Books).FirstOrDefaultAsync(x => x.Id == id);
        }

    }
}