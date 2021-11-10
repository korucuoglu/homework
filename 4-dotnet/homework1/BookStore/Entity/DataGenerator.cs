using System;
using System.Linq;
using BookStore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BookStore.Entity
{

    public class DataGenerator
    {

        public static void Initialize(IServiceProvider service)
        {

            using (var context = new DataContext(service.GetRequiredService<DbContextOptions<DataContext>>()))
            {

                if (!context.Genres.Any())
                {

                    context.Genres.AddRange(

                        new Genre { Name = "Personal Growth" },
                        new Genre { Name = "Science Fiction" },
                        new Genre { Name = "Romance" }
                    );
                }

                context.SaveChanges();

                if (!context.Authors.Any())
                {


                    context.Authors.AddRange(

                        new Author
                        {
                            Name = "Halit",
                            SurName = "Korucuoğlu",
                            Books = {
                            new Book
                            {

                                Title = "Denemeler",
                                GenreId = 2,
                                PageCount = 200,
                                Publishdate = new System.DateTime(2001, 06, 12)
                            },
                            new Book
                            {

                                Title = "Mukaddime",
                                GenreId = 1,
                                PageCount = 350,
                                Publishdate = new System.DateTime(2001, 06, 12)
                            }
                           }

                        },

                        new Author
                        {
                            Name = "Betül",
                            SurName = "Korucuoğlu",
                            Books = {
                            new Book
                            {

                                Title = "Müthiş Hayat",
                                GenreId = 3,
                                PageCount = 200,
                                Publishdate = new System.DateTime(2001, 06, 12)
                            },
                            new Book
                            {

                                Title = "Tespit",
                                GenreId = 3,
                                PageCount = 350,
                                Publishdate = new System.DateTime(2001, 06, 12)
                            }
                           }

                        },

                        new Author
                        {
                            Name = "Hüseyin",
                            SurName = "Korucuoğlu",
                            Books = {
                                new Book
                                {

                                    Title = "Lean Startup",
                                    GenreId = 1,
                                    PageCount = 200,
                                    Publishdate = new System.DateTime(2001, 06, 12)
                                },

                                new Book
                                {

                                    Title = "İnsanlar ve Hayvanlar",
                                    GenreId = 2,
                                    PageCount = 350,
                                    Publishdate = new System.DateTime(2001, 06, 12)
                                },

                                new Book
                                {

                                    Title = "İnsanlar ve Hayvanlar",
                                    GenreId = 3,
                                    PageCount = 350,
                                    Publishdate = new System.DateTime(2001, 06, 12)
                                }
                           }

                        }

                    );

                }

                context.SaveChanges();


            }

        }

    }

}