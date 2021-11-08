using System.Threading.Tasks;
using AutoMapper;
using BookStore.Filters;
using BookStore.Models;
using BookStore.DatabaseOperations.Services;
using Microsoft.AspNetCore.Mvc;
using BookStore.ViewModels.Genre;
using BookStore.DatabaseOperations.Services.Abstract;

namespace BookStore.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class GenresController : CustomBaseController
    {
        private readonly IGenericService<Genre> _service;
        private readonly IMapper _mapper;

        public GenresController(IGenericService<Genre> service, IMapper mapper)
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