using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using BookStore.Models;
using BookStore.Service;
using BookStore.ViewModels.Books;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{

    [ApiController]
    [Route("api/{[controller]}")]
    public class BooksController : ControllerBase
    {
        private readonly IBookService<Book> _service;
        private readonly IMapper _mapper;

        public BooksController(IBookService<Book> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {

            return Ok(_mapper.Map<List<GetBookViewModel>>(await _service.GetAll()));
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {


            return Ok(_mapper.Map<GetBookViewModel>(await _service.GetByIdAsyc(id)));

        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateBookViewModel model)
        {

            await _service.AddAsync(_mapper.Map<Book>(model));
            return NoContent();
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateBookViewModel updateModel)
        {

            var data = await _service.GetByIdAsyc(updateModel.Id);

            if (data == null)
            {

                return BadRequest("Bu Id değerine sahip bir ürün bulunamadı");
            }

            await _service.Update(_mapper.Map<Book>(updateModel));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {

            var data = _service.GetByIdAsyc(id);

            if (data == null)
            {
                return BadRequest("Bu Id değerine sahip bir ürün bulunamadı");
            }

            _service.DeleteById(id);


            /* 
            _service.Delete(data); hata vermektedir. Çünkü biz Task<Book> yollarken o bizden Book beklemekte. 

            */

            return NoContent();
        }
    }
}