using System;

namespace BookStore.BookOperations.CreateBook
{
    public class CreateBookCommand
    {

        public string Title { get; set; }
        public int GenreId { get; set; }
        public int PageCount { get; set; }
        public DateTime Publishdate { get; set; }
    }
}