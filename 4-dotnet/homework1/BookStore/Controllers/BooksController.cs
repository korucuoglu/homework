using System.Threading.Tasks;
using AutoMapper;
using BookStore.Filters;
using BookStore.Models;
using BookStore.DatabaseOperations.Services;
using BookStore.ViewModels.Books;
using Microsoft.AspNetCore.Mvc;
using BookStore.Entity;
using BookStore.DatabaseOperations.Services.Abstract;

namespace BookStore.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class BooksController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IBookService _service;
        public BooksController(IMapper mapper, IBookService service)
        {
            _service = service;
            _mapper = mapper;

        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await _service.GetAllWithGenresAsync();

            return CreateActionResultInstance(data);
        }


        [HttpGet("{id}")]
        [ServiceFilter(typeof(NotFoundFilter<Book>))]
        public async Task<IActionResult> GetById(int id)
        {

            var data = await _service.GetFirstOrDefaultWithGenresAsync(id);

            return CreateActionResultInstance(data);

        }

        [ServiceFilter(typeof(ValidationFilter))]
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] BookCreateViewModel model)
        {
            var data = await _service.AddAsync<BookGetViewModel>(_mapper.Map<Book>(model));
            return CreateActionResultInstance(data);

        }

        [ServiceFilter(typeof(ValidationFilter))]
        public IActionResult Update([FromBody] BookUpdateViewModel updateModel)
        {

            var data = _service.Update(_mapper.Map<Book>(updateModel));
            return CreateActionResultInstance(data);

        }

        [HttpDelete("{id}")]
        [ServiceFilter(typeof(NotFoundFilter<Book>))]
        public IActionResult Delete(int id)
        {
            var data = _service.RemoveById(id);
            return CreateActionResultInstance(data);

        }
    }
}