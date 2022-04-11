using FileUpload.Shared.Wrappers;
using Homework2.API.Dtos.Author;
using Homework2.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Homework2.API.Services
{
    public interface IAuthorService
    {
        Task<Response<List<AuthorDto>>> GetAll();
        Task<Response<AuthorDto>> GetById(int id);

        Task<Response<int>> Save(AddAuthorDto model);

        Task<Response<NoContent>> Update(UpdateAuthorDto model);

        Task<Response<NoContent>> Delete(int id);
    }
}
