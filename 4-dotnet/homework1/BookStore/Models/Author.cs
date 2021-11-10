using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models
{

    public class Author
    {
        public Author()
        {
            Books = new List<Book>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }

        public string SurName { get; set; }

        public string Birthday { get; set; } = DateTime.Now.ToString();

        public List<Book> Books { get; set; }


    }
}