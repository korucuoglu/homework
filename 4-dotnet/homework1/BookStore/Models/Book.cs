using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models
{
    public class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public int PageCount { get; set; }
        public DateTime Publishdate { get; set; }

        public int GenreId { get; set; }
        public Genre Genre { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }


    }

}