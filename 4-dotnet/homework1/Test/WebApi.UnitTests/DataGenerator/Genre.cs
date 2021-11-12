using BookStore.Entity;
using BookStore.Models;

namespace WebApi.UnitTests.DataGenerator
{
    public static class Genres
    {
        public static void AddGenres(this DataContext context)
        {
            context.Genres.AddRange(

                       new Genre { Name = "Personal Growth" },
                       new Genre { Name = "Science Fiction" },
                       new Genre { Name = "Romance" }
                   );
        }
    }
}