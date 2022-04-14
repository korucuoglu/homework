using AutoMapper;
using FileUpload.Shared.Wrappers;
using Homework2.API.Dtos.Author;
using Homework2.API.Models;
using Homework2.API.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Homework2.API.Features.Queries.Authors
{
    public class AuthorGetByIdQuery : IRequest<Response<AuthorDto>>
    {
        public int Id { get; set; }
    }

    public class AuthorGetByIdQueryHandler : IRequestHandler<AuthorGetByIdQuery, Response<AuthorDto>>
    {

        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;

        public AuthorGetByIdQueryHandler(IAuthorRepository authorRepository, IMapper mapper)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
        }

        public async Task<Response<AuthorDto>> Handle(AuthorGetByIdQuery request, CancellationToken cancellationToken)
        {
            var data = await _authorRepository.GetById(request.Id);

            if (data == null)
            {
                return Response<AuthorDto>.Fail("Böyle bir ürün bulunamadı", 500);
            }

            return Response<AuthorDto>.Success(_mapper.Map<AuthorDto>(data), 200);
        }
    }


}
