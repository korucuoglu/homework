using System;
using System.Collections.Generic;

namespace BookStore.ViewModels.Books
{
    public class AuthorUpdateViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string SurName { get; set; }

        public string Birthday { get; set; }

        public List<BookUpdateViewModel> Books { get; set; }
    }
}