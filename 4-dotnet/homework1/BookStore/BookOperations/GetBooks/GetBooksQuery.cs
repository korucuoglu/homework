namespace BookStore.BookOperations.GetBooks
{
    public class GetBooksQuery
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public int PageCount { get; set; }
        public string Publishdate { get; set; }
    }
}