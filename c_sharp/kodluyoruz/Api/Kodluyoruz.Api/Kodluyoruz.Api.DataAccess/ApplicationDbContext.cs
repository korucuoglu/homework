using KodluyoruzTest.Entities;
using Microsoft.EntityFrameworkCore;

namespace KodluyoruzTest.DataAccess
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }


        public DbSet<Product> Products { get; set; }


    }
}
