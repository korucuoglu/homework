using System;
using System.Collections.Generic;

namespace BookStore.ViewModels.Books
{
    public class AuthorCreateViewModel
    {

        public string Name { get; set; }

        public string SurName { get; set; }

        public string Birthday { get; set; }

    }

    public class AuthorCreateViewModelWithBooks : AuthorUpdateViewModel
    {

        public AuthorCreateViewModelWithBooks()
        {
            Books = new List<BookCreateViewModel>();
        }

        public new List<BookCreateViewModel> Books { get; set; }

    }
}