using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models
{
    public class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public int GenreId { get; set; } = 200;
        public int PageCount { get; set; }

        public DateTime Publishdate { get; set; } = new DateTime(2012, 12, 2);

    }

}