using Homework2.API.Models;
using Homework2.API.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Homework2.API.Features.Command.Authors
{
    public class UpdateAuthorCommand : IRequest<bool>
    {
        public Author Author { get; set; }
    }

    public class UpdateAuthorCommandHandler : IRequestHandler<UpdateAuthorCommand, bool>
    {
        private readonly IAuthorRepository _authorRepository;

        public UpdateAuthorCommandHandler(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public async Task<bool> Handle(UpdateAuthorCommand request, CancellationToken cancellationToken)
        {
            return await _authorRepository.Update(request.Author);
        }
    }
}
