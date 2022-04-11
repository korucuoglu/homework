using AutoMapper;
using FileUpload.Shared.Wrappers;
using Homework2.API.Dtos.Author;
using Homework2.API.Features.Command.Authors;
using Homework2.API.Features.Queries.Authors;
using Homework2.API.Models;
using MediatR;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Homework2.API.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public AuthorService(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        public async Task<Response<NoContent>> Delete(int id)
        {
            var result = await _mediator.Send(new DeleteAuthorCommand() { AuthorId = id });

            if (!result)
            {
                return Response<NoContent>.Fail("Silme sırasında hata meydana geldi", 500);
            }

            return Response<NoContent>.Success(204);
        }

        public async Task<Response<List<AuthorDto>>> GetAll()
        {
            var data = await _mediator.Send(new AuthorGetAllQuery());

            var mapperData = _mapper.Map<List<AuthorDto>>(data);

            return Response<List<AuthorDto>>.Success(mapperData, 200);
        }

        public async Task<Response<AuthorDto>> GetById(int id)
        {
            var data = await _mediator.Send(new AuthorGetByIdQuery() { Id = id });

            if (data == null)
            {
                return Response<AuthorDto>.Fail($"{id} değerine sahip veri bulunamadı", 500);
            }

            return Response<AuthorDto>.Success(_mapper.Map<AuthorDto>(data), 200);
        }

        public async Task<Response<int>> Save(AddAuthorDto model)
        {
            var author = _mapper.Map<Author>(model);
            
            var data = await _mediator.Send(new AddAuthorCommand() { Author = author });

            if (data <= 0)
            {
                return Response<int>.Fail("Veri kaydedilemedi", 201);
            }

            return Response<int>.Success(data, 201);
        }

        public async Task<Response<NoContent>> Update(UpdateAuthorDto model)
        {
            var author = _mapper.Map<Author>(model);

            var result = await _mediator.Send(new UpdateAuthorCommand() { Author = author });

            if (!result)
            {
                return Response<NoContent>.Fail("Veri güncellenemedi", 500);
            }

            return Response<NoContent>.Success(204);
        }
    }
}
