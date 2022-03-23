using System.Collections.Generic;
using BookStore.Models;
using BookStore.ViewModels.Books;

namespace BookStore.ViewModels.Genre
{
    public class GenreCreateViewModel
    {

        public GenreCreateViewModel()
        {
            Books = new List<Book>();
        }
        public string Name { get; set; }

        public bool IsActive { get; set; }

        public List<Book> Books { get; set; }
    }
}