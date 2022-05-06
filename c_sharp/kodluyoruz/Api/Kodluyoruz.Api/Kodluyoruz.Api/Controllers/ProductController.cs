using KodluyoruzTest.DataAccess;
using KodluyoruzTest.Entities;
using Microsoft.AspNetCore.Mvc;

namespace KodluyoruzTest.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            //return Ok(_context.Products.ToList());
            return Ok(_context.Products.ToList());
        }

        [HttpPost]
        public IActionResult Save(Product entity)
        {
            _context.Products.Add(entity);
            _context.SaveChanges();
            return Ok(entity.Id);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var data = _context.Products.Find(id);
            return Ok(data);
        }

        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            var data = _context.Products.Find(id);
            _context.Products.Remove(data);
            _context.SaveChanges();
            return NoContent();
        }


    }
}
