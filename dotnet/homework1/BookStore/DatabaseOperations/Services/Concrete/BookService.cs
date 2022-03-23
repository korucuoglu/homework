using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using BookStore.DatabaseOperations.Repositories.Abstract;
using BookStore.DatabaseOperations.Services.Abstract;
using BookStore.Entity;
using BookStore.Models;
using BookStore.Shared;
using BookStore.ViewModels.Books;

namespace BookStore.DatabaseOperations.Services.Concrete
{

    public class BookService : GenericService<Book>, IBookService
    {
        private readonly IBookRepository _context;
        private readonly IMapper _mapper;
        public BookService(IRepository<Book> repository, IMapper mapper, IBookRepository context) : base(repository, mapper)
        {
            _context = context;
            _mapper = mapper;

        }

        public async Task<Response<List<BookGetViewModel>>> GetAllWithGenresAsync()
        {
            var data = _mapper.Map<List<BookGetViewModel>>(await _context.GetAllWithGenresAsync());
            return Response<List<BookGetViewModel>>.Success(data, 200);


        }

        public async Task<Response<BookGetViewModel>> GetFirstOrDefaultWithGenresAsync(int id)
        {
            var data = _mapper.Map<BookGetViewModel>(await _context.GetFirstOrDefaultWithGenresAsync(id));
            return Response<BookGetViewModel>.Success(data, 200);
        }

        public override async Task<Response<T>> AddAsync<T>(Book entity) where T : class
        {

            var book = await _repository.SingleOrDefaultAsync(x => x.Title == entity.Title);
            if (book != null)
            {
                return Response<T>.Fail("Kitap zaten mevcut", 500);
            }

            var data = _mapper.Map<T>(await _repository.AddAsync(entity));
            return Response<T>.Success(data, 201);

        }


    }
}