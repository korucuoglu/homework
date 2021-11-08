using System;

namespace BookStore.ViewModels.Books
{
    public class BookCreateViewModel
    {

        public string Title { get; set; }
        public int GenreId { get; set; }
        public int PageCount { get; set; }
        public DateTime Publishdate { get; set; }
    }
}