using System.Text.Json.Serialization;

namespace BookStore.ViewModels.Books
{
    public class GetBookViewModel
    {
        public string Title { get; set; }

        [JsonIgnore]
        public int GenreId { get; set; }
        public int PageCount { get; set; }
        public string Publishdate { get; set; }

        public string Genre => ((GenreEnum)GenreId).ToString();
    }
}