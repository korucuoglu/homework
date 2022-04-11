using Homework2.API.Dtos.Author;
using Homework2.API.Filters;
using Homework2.API.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Homework2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : BaseApiController
    {
        private readonly IAuthorService _service;

        public AuthorController(IAuthorService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await  _service.GetAll();

            return Result(data);
        }

        [ServiceFilter(typeof(NotFoundFilter))]
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _service.GetById(id);

            return Result(data);
        }

        [HttpPost]
        public async Task<IActionResult> Save(AddAuthorDto model)
        {
            var data = await _service.Save(model);

            return Result(data);
        }

        [ServiceFilter(typeof(NotFoundFilter))]
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var data = await _service.Delete(id);

            return Result(data);
        }

        [ServiceFilter(typeof(NotFoundFilter))]
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, UpdateAuthorDto model)
        {
            model.Id = id;

            var data = await _service.Update(model);

            return Result(data);
        }
    }
}
