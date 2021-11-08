using System;

namespace BookStore.ViewModels.Books
{
    public class BookUpdateViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int GenreId { get; set; }
        public int PageCount { get; set; }
        public DateTime Publishdate { get; set; }
    }
}