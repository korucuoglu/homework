using System.Threading.Tasks;
using AutoMapper;
using BookStore.DatabaseOperations.Services.Abstract;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{


    [ApiController]
    [Route("[contoller]")]
    public class AuthorsController : CustomBaseController
    {
        private readonly IGenericService<Author> _service;
        private readonly IMapper _mapper;

        public AuthorsController(IGenericService<Author> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }


        // public async Task<IActionResult> GetAll()
        // {

        //     return Ok();
        // }
    }
}