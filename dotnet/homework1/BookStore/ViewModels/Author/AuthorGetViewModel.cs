
using System.Collections.Generic;
using System.ComponentModel;
using BookStore.Models;
using BookStore.ViewModels.Books;

namespace BookStore.ViewModels.Author
{

    public class AuthorGetViewModel
    {


        public int Id { get; set; }
        public string Name { get; set; }

        public string SurName { get; set; }

        public string Birthday { get; set; }

    }

    public class AuthorGetViewModelWithBooks
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public string SurName { get; set; }

        public string Birthday { get; set; }

        public List<BookGetViewModel> Books { get; set; }
    }
}