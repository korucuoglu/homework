using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using BookStore.DatabaseOperations.Repositories.Abstract;
using BookStore.DatabaseOperations.Services.Abstract;
using BookStore.Entity;
using BookStore.Models;
using BookStore.Shared;
using BookStore.ViewModels.Author;

namespace BookStore.DatabaseOperations.Services.Concrete
{

    public class AuthorService : GenericService<Author>, IAuthorService
    {
        private readonly IAuthorRepository _context;
        private readonly IMapper _mapper;
        public AuthorService(IRepository<Author> repository, IMapper mapper, IAuthorRepository context) : base(repository, mapper)
        {
            _context = context;
            _mapper = mapper;

        }

        public async Task<Response<List<AuthorGetViewModelWithBooks>>> GetAllWithBooks()
        {
            var data = _mapper.Map<List<AuthorGetViewModelWithBooks>>(await _context.GetAllWithGenresAsync());
            return Response<List<AuthorGetViewModelWithBooks>>.Success(data, 200);


        }

        public async Task<Response<AuthorGetViewModelWithBooks>> GetWithBooks(int id)
        {
            var data = _mapper.Map<AuthorGetViewModelWithBooks>(await _context.GetFirstOrDefaultWithGenresAsync(id));
            return Response<AuthorGetViewModelWithBooks>.Success(data, 200);
        }
    }
}