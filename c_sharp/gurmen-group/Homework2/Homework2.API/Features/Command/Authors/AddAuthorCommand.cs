using AutoMapper;
using FileUpload.Shared.Wrappers;
using Homework2.API.Models;
using Homework2.API.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Homework2.API.Features.Command.Authors
{
    public class AddAuthorCommand : IRequest<Response<int>>
    {
        public string Name { get; set; }
    }

    public class AddAuthorCommandHandler : IRequestHandler<AddAuthorCommand, Response<int>>
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;

        public AddAuthorCommandHandler(IAuthorRepository authorRepository, IMapper mapper)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
        }

        public async Task<Response<int>> Handle(AddAuthorCommand request, CancellationToken cancellationToken)
        {
            var author = _mapper.Map<Author>(request);

            var data = await _authorRepository.Save(author);

            if (data <= 0)
            {
                return Response<int>.Fail("Hata meydana geldi", 500);
            }

            return Response<int>.Success(data, 201);

        }
    }
}
