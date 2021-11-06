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

                if (context.Books.Any())
                {
                    return;
                }

                context.Books.AddRange(new Book
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

                Title = "Çanlar Kimin İçin Çalıyor",
                GenreId = 3,
                PageCount = 500,
                Publishdate = new System.DateTime(2001, 06, 12)
            });

                context.SaveChanges();

            }




        }


    }

}