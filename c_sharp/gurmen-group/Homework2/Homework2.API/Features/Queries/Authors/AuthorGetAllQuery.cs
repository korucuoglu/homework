using Homework2.API.Models;
using Homework2.API.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Homework2.API.Features.Queries.Authors
{
    public class AuthorGetByIdQuery : IRequest<Author>
    {
        public int Id { get; set; }
    }

    public class AuthorGetByIdQueryHandler : IRequestHandler<AuthorGetByIdQuery, Author>
    {

        private readonly IAuthorRepository _authorRepository;

        public AuthorGetByIdQueryHandler(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public async Task<Author> Handle(AuthorGetByIdQuery request, CancellationToken cancellationToken)
        {
            return await _authorRepository.GetById(request.Id);
        }
    }


}
