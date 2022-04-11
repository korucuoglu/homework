using Homework2.API.Models;
using Homework2.API.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Homework2.API.Features.Command.Authors
{
    public class AddAuthorCommand: IRequest<int>
    {
        public Author Author { get; set; }
    }

    public class AddAuthorCommandHandler : IRequestHandler<AddAuthorCommand, int>
    {
        private readonly IAuthorRepository _authorRepository;

        public AddAuthorCommandHandler(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public async Task<int> Handle(AddAuthorCommand request, CancellationToken cancellationToken)
        {
            return await _authorRepository.Save(request.Author);
        }
    }
}
