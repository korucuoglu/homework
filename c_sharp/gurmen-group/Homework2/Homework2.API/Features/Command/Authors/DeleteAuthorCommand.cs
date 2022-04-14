using FileUpload.Shared.Wrappers;
using Homework2.API.Models;
using Homework2.API.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Homework2.API.Features.Command.Authors
{
    public class DeleteAuthorCommand : IRequest<Response<NoContent>>
    {
        public int AuthorId { get; set; }
    }

    public class DeleteAuthorCommandHandler : IRequestHandler<DeleteAuthorCommand, Response<NoContent>>
    {
        private readonly IAuthorRepository _authorRepository;

        public DeleteAuthorCommandHandler(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public async Task<Response<NoContent>> Handle(DeleteAuthorCommand request, CancellationToken cancellationToken)
        {
            var result =  await _authorRepository.Delete(request.AuthorId);

            if (!result)
            {
                return Response<NoContent>.Fail("Hata meydana geldi", 500);
            }

            return Response<NoContent>.Success(200);
        }
    }
}
