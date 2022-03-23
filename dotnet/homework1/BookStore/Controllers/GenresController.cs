using System.Threading.Tasks;
using AutoMapper;
using BookStore.Filters;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using BookStore.ViewModels.Genre;


namespace BookStore.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class GenresController : CustomBaseController
    {
        private readonly IGenreService _service;
        private readonly IMapper _mapper;


        public GenresController(IGenreService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;

        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await _service.GetAllAsync<GenreGetViewModel>();

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
        [ServiceFilter(typeof(NotFoundFilter<Genre>))]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _service.GetByIdAsync<GenreGetViewModel>(id);

            return CreateActionResultInstance(data);

        }

        [HttpGet("book/{id:int}")] // GET /genres/book/2
        public async Task<IActionResult> GetFirstWithBooks(int id)
        {
            var data = await _service.GetFirstWithBooks(id);

            return CreateActionResultInstance(data);
        }

        [ServiceFilter(typeof(ValidationFilter))]
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] GenreCreateViewModel model)
        {
            var data = await _service.AddAsync<GenreGetViewModel>(_mapper.Map<Genre>(model));

            return CreateActionResultInstance(data);

        }

        [ServiceFilter(typeof(ValidationFilter))]
        public IActionResult Update([FromBody] GenreUpdateViewModel updateModel)
        {

            var data = _service.Update(_mapper.Map<Genre>(updateModel));
            return CreateActionResultInstance(data);

        }

        [HttpDelete("{id}")]
        [ServiceFilter(typeof(NotFoundFilter<Genre>))]
        public IActionResult Delete(int id)
        {
            var data = _service.RemoveById(id);
            return CreateActionResultInstance(data);

        }
    }
}