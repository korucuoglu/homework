using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.BookOperations.CreateBook;
using BookStore.Models;
using BookStore.Service;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{

    [ApiController]
    [Route("api/{[controller]}")]
    public class BooksController : ControllerBase
    {
        private readonly IBookService<Book> _service;

        public BooksController(IBookService<Book> service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {

            return Ok(await _service.GetAll());
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {

            var list = await _service.GetByIdAsyc(id);
            return Ok(list);

        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateBookCommand model)
        {

            await _service.AddAsync(model);
            return NoContent();
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Book updateModel)
        {

            var data = await _service.GetByIdAsyc(updateModel.Id);

            if (data == null)
            {

                return BadRequest("Bu Id değerine sahip bir ürün bulunamadı");
            }


            await _service.Update(updateModel);
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