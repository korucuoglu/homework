using AutoMapper;
using FileUpload.Shared.Wrappers;
using Homework2.API.Dtos.Author;
using Homework2.API.Repositories;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Homework2.API.Features.Queries.Authors
{
    public class AuthorGetAllQuery: IRequest<Response<List<AuthorDto>>>
    {
    }

    public class AuthorGetAllQueryHandler : IRequestHandler<AuthorGetAllQuery, Response<List<AuthorDto>>>
    {

        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;

        public AuthorGetAllQueryHandler(IAuthorRepository authorRepository, IMapper mapper)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
        }

        public async Task<Response<List<AuthorDto>>> Handle(AuthorGetAllQuery request, CancellationToken cancellationToken)
        {
            var data =  await _authorRepository.GetAll();

            var dto = _mapper.Map<List<AuthorDto>>(data);

            return Response<List<AuthorDto>>.Success(dto, 200);
        }
    }


}
