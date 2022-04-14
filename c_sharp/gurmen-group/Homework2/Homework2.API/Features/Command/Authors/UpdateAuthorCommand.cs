using AutoMapper;
using FileUpload.Shared.Wrappers;
using Homework2.API.Models;
using Homework2.API.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Homework2.API.Features.Command.Authors
{
    public class UpdateAuthorCommand : IRequest<Response<NoContent>>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class UpdateAuthorCommandHandler : IRequestHandler<UpdateAuthorCommand, Response<NoContent>>
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;

        public UpdateAuthorCommandHandler(IAuthorRepository authorRepository, IMapper mapper)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
        }

        public async Task<Response<NoContent>> Handle(UpdateAuthorCommand request, CancellationToken cancellationToken)
        {
            var author = _mapper.Map<Author>(request);
            
            var result = await _authorRepository.Update(author);

            if (!result)
            {
                return Response<NoContent>.Fail("Hata meydana geldi", 500);
            }

            return Response<NoContent>.Success(200);
        }
    }
}
