using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using BookStore.Models;
using BookStore.Service;
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

        public BooksController(IGenericService<Book> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            //var data = _mapper.Map<Response<List<GetBookViewModel>>>(await _service.GetAllAsync());

            var data = await _service.GetAllAsync();

            var MappingData = _mapper.Map<Response<List<GetBookViewModel>>>(data);

            return CreateActionResultInstance(MappingData);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {

            var data = await _service.GetByIdAsyc(id);
            var MappingData = _mapper.Map<Response<GetBookViewModel>>(data);

            return CreateActionResultInstance(MappingData);

        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateBookViewModel model)
        {

            var data = await _service.AddAsync(_mapper.Map<Book>(model));
            return CreateActionResultInstance(data);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateBookViewModel updateModel)
        {

            var data = await _service.Update(_mapper.Map<Book>(updateModel));
            return CreateActionResultInstance(data);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var data = _service.DeleteById(id);
            return CreateActionResultInstance(data);

        }
    }
}