using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using BookStore.Filters;
using BookStore.Models;
using BookStore.Services;
using BookStore.Services.Logger;
using BookStore.Shared;
using BookStore.ViewModels.Books;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{

    [ApiController]
    [Route("api/{[controller]}")]
    public class BooksController : CustomBaseController
    {
        private readonly IGenericService<Book> _service;
        private readonly IMapper _mapper;
        public ILoggerService _logger;

        public BooksController(IGenericService<Book> service, IMapper mapper, ILoggerService logger)
        {
            _service = service;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            var data = await _service.GetAllAsync();

            var MappingData = _mapper.Map<Response<List<GetBookViewModel>>>(data);

            return CreateActionResultInstance(MappingData);
        }


        [HttpGet("{id}")]
        [ServiceFilter(typeof(NotFoundFilter<Book>))]
        public async Task<IActionResult> GetById(int id)
        {

            var data = await _service.GetByIdAsyc(id);
            var MappingData = _mapper.Map<Response<GetBookViewModel>>(data);

            return CreateActionResultInstance(MappingData);

        }

        [ServiceFilter(typeof(ValidationFilter))]
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateBookViewModel model)
        {
            if (!ModelState.IsValid)
            {
                throw new System.Exception("Model üzerinden gelen verileri doğrulayın");
            }
            var data = await _service.AddAsync(_mapper.Map<Book>(model));
            return CreateActionResultInstance(data);
        }
        [HttpPut]
        [ServiceFilter(typeof(ValidationFilter))]
        public async Task<IActionResult> Update([FromBody] UpdateBookViewModel updateModel)
        {

            var data = await _service.Update(_mapper.Map<Book>(updateModel));
            return CreateActionResultInstance(data);
        }

        [HttpDelete("{id}")]
        [ServiceFilter(typeof(NotFoundFilter<Book>))]
        public IActionResult Delete(int id)
        {
            var data = _service.DeleteById(id);
            return CreateActionResultInstance(data);

        }
    }
}