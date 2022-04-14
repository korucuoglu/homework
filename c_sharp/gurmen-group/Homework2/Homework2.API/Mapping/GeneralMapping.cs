using AutoMapper;
using Homework2.API.Dtos.Author;
using Homework2.API.Features.Command.Authors;
using Homework2.API.Models;

namespace Homework2.API.Mapping
{
    public class GeneralMapping: Profile
    {
        public GeneralMapping()
        {
            CreateMap<Author, AuthorDto>();

            CreateMap<AddAuthorCommand, Author>();
            CreateMap<UpdateAuthorCommand, Author>();
        }

    }
}
