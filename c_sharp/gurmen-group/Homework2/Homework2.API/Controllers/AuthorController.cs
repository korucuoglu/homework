using Homework2.API.Features.Command.Authors;
using Homework2.API.Features.Queries.Authors;
using Homework2.API.Filters;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Homework2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : BaseApiController
    {
        private readonly IMediator _mediator;

        public AuthorController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await _mediator.Send(new AuthorGetAllQuery());
            return Result(data);
        }

        [ServiceFilter(typeof(NotFoundFilter))]
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _mediator.Send(new AuthorGetByIdQuery() { Id = id });

            return Result(data);
        }

        [HttpGet("books/{id:int}")]
        public async Task<IActionResult> GetAuthorByIdWithBook(int id)
        {
            var data = await _mediator.Send(new AuthorGetByIdWithBookQuery() { Id = id });
            return Result(data);
        }

        [HttpPost]
        public async Task<IActionResult> Save(AddAuthorCommand model)
        {
            var data = await _mediator.Send(model);

            return Result(data);
        }

        [ServiceFilter(typeof(NotFoundFilter))]
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var data = await _mediator.Send(new DeleteAuthorCommand() { AuthorId = id });

            return Result(data);
        }

        [ServiceFilter(typeof(NotFoundFilter))]
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, UpdateAuthorCommand model)
        {
            model.Id = id;

            var data = await _mediator.Send(model);

            return Result(data);
        }
    }
}
