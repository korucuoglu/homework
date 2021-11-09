using System.Threading.Tasks;
using AutoMapper;
using BookStore.Filters;
using BookStore.Models;
using BookStore.DatabaseOperations.Services;
using Microsoft.AspNetCore.Mvc;
using BookStore.ViewModels.Genre;
using BookStore.DatabaseOperations.Services.Abstract;
using BookStore.Entity;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class GenresController : CustomBaseController
    {
        private readonly IGenreService _service;
        private readonly IMapper _mapper;

        private readonly DataContext _context;

        public GenresController(IGenreService service, IMapper mapper, DataContext context)
        {
            _service = service;
            _mapper = mapper;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await _context.Genres.Include(x => x.Books).ToListAsync();

            return Ok(data);
        }


        [HttpGet("{id}")]
        [ServiceFilter(typeof(NotFoundFilter<Genre>))]
        public async Task<IActionResult> GetById(int id)
        {

            var data = await _service.GetByIdAsync<GenreGetViewModel>(id);

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