using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using BookStore.DatabaseOperations.Repositories.Abstract;
using BookStore.Models;
using BookStore.Shared;

using BookStore.ViewModels.Genre;

namespace BookStore.DatabaseOperations.Services.Concrete
{

    public class GenreService : GenericService<Genre>, IGenreService
    {
        private readonly IGenreRepository _context;
        private readonly IMapper _mapper;
        public GenreService(IRepository<Genre> repository, IMapper mapper, IGenreRepository context) : base(repository, mapper)
        {
            _context = context;
            _mapper = mapper;

        }

        public async Task<Response<List<GenreGetViewModel>>> GetAllWithBooks()
        {
            var data = _mapper.Map<List<GenreGetViewModel>>(await _context.GetAllWithBooks());
            return Response<List<GenreGetViewModel>>.Success(data, 200);
        }

        public async Task<Response<GenreGetViewModel>> GetFirstWithBooks(int id)
        {
            var data = _mapper.Map<GenreGetViewModel>(await _context.GetFirstWithBooks(id));
            return Response<GenreGetViewModel>.Success(data, 200);
        }

        // public async Task<Response<List<BookGetViewModel>>> GetAllWithGenresAsync()
        // {
        //     var data = _mapper.Map<List<BookGetViewModel>>(await _context.GetAllWithGenresAsync());
        //     return Response<List<BookGetViewModel>>.Success(data, 200);


        // }

        // public async Task<Response<BookGetViewModel>> GetFirstOrDefaultWithGenresAsync(int id)
        // {
        //     var data = _mapper.Map<BookGetViewModel>(await _context.GetFirstOrDefaultWithGenresAsync(id));
        //     return Response<BookGetViewModel>.Success(data, 200);
        // }
    }
}