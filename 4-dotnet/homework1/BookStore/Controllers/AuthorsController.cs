using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using BookStore.Entity;
using Microsoft.EntityFrameworkCore;
using BookStore.ViewModels.Author;
using BookStore.ViewModels.Books;
using System.Collections.Generic;
using System.Linq;
using BookStore.DatabaseOperations.Services.Abstract;
using BookStore.Filters;
using BookStore.Models;
using BookStore.ViewModels;
using BookStore.Shared;
using Microsoft.AspNetCore.Http;

namespace BookStore.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class AuthorsController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IAuthorService _service;
        private readonly IBookService _bookService;





        public AuthorsController(IMapper mapper, IAuthorService service, IBookService bookService)
        {
            _service = service;
            _mapper = mapper;
            _bookService = bookService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await _service.GetAllAsync<AuthorGetViewModel>();

            return CreateActionResultInstance(data);
        }

        [HttpGet]
        [Route("books")]
        public async Task<IActionResult> GetAllWithBooks()
        {
            var data = await _service.GetAllWithBooks();

            return CreateActionResultInstance(data);
        }


        [HttpGet("{id:int}")]
        [ServiceFilter(typeof(NotFoundFilter<Author>))]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _service.GetByIdAsync<AuthorGetViewModel>(id);

            return CreateActionResultInstance(data);

        }

        [HttpGet("book/{id:int}")] // GET /genres/book/2
        public async Task<IActionResult> GetFirstWithBooks(int id)
        {
            var data = await _service.GetWithBooks(id);

            return CreateActionResultInstance(data);
        }

        [ServiceFilter(typeof(ValidationFilter))]
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] AuthorCreateViewModel model)
        {
            var data = await _service.AddAsync<AuthorGetViewModel>(_mapper.Map<Author>(model));

            return CreateActionResultInstance(data);

        }

        [ServiceFilter(typeof(ValidationFilter))]
        [HttpPost]
        [Route("books")]
        public async Task<IActionResult> Add([FromBody] AuthorCreateViewModelWithBooks model, [FromForm] IFormFile file)
        {
            if (file != null)
            {
                return Ok("dqdqd");
            }

            await _bookService.AddRangeAsync<BookGetViewModel>(_mapper.Map<List<Book>>(model.Books));

            var data = await _service.AddAsync<AuthorGetViewModelWithBooks>(_mapper.Map<Author>(model));

            return Ok(file.FileName);

            // return CreateActionResultInstance(data);

        }

        [ServiceFilter(typeof(ValidationFilter))]
        public IActionResult Update([FromBody] AuthorUpdateViewModel updateModel)
        {

            var data = _service.Update(_mapper.Map<Author>(updateModel));
            return CreateActionResultInstance(data);

        }

        [HttpDelete("{id}")]
        [ServiceFilter(typeof(NotFoundFilter<Author>))]
        public async Task<IActionResult> Delete(int id)
        {
            var data = await _service.GetWithBooks(id);

            if (data.Data.Books.Count > 0)
            {

                return CreateActionResultInstance(Response<NoContent>.Fail("Kitabı olan yazar silinemez", 500));
            }

            return CreateActionResultInstance(_service.RemoveById(id));

        }
    }
}