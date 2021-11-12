using BookStore.Entity;
using BookStore.Models;

namespace WebApi.UnitTests.DataGenerator
{
    public static class Authors
    {

        public static void AddAuthors(this DataContext context)
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
    }

}