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
    public class AuthorGetAllQuery: IRequest<List<Author>>
    {
    }

    public class AuthorGetAllQueryHandler : IRequestHandler<AuthorGetAllQuery, List<Author>>
    {

        private readonly IAuthorRepository _authorRepository;

        public AuthorGetAllQueryHandler(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public async Task<List<Author>> Handle(AuthorGetAllQuery request, CancellationToken cancellationToken)
        {
            return await _authorRepository.GetAll();
        }
    }


}
