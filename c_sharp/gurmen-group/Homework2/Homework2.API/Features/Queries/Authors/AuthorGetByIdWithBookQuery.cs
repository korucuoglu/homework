using AutoMapper;
using FileUpload.Shared.Wrappers;
using Homework2.API.Dtos.Author;
using Homework2.API.Models;
using Homework2.API.Repositories;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Homework2.API.Features.Queries.Authors
{
    public class AuthorGetByIdWithBookQuery : IRequest<Response<IEnumerable<AuthorBook>>>
    {
        public int Id { get; set; }
    }

    public class AuthorGetByIdWithBookQueryHandler : IRequestHandler<AuthorGetByIdWithBookQuery, Response<IEnumerable<AuthorBook>>>
    {

        private readonly IAuthorRepository _authorRepository;

        public AuthorGetByIdWithBookQueryHandler(IAuthorRepository authorRepository, IMapper mapper)
        {
            _authorRepository = authorRepository;
        }

        public async Task<Response<IEnumerable<AuthorBook>>> Handle(AuthorGetByIdWithBookQuery request, CancellationToken cancellationToken)
        {
            var data = await _authorRepository.GetAuthorByIdWithBook(request.Id);

            return Response<IEnumerable<AuthorBook>>.Success(data, 200);
        }
    }


}
