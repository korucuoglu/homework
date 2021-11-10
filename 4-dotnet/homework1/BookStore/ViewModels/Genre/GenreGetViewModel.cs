using System.Collections.Generic;
using BookStore.Models;
using BookStore.ViewModels.Books;

namespace BookStore.ViewModels.Genre
{
    public class GenreGetViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }


    }
    public class GenreGetViewModelWithBooks
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public List<BookGetViewModel> Books { get; set; }
    }


}