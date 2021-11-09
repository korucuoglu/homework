using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models
{

    public class Author
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }

        public string SurName { get; set; }

        public DateTime Birthday { get; set; }
    }
}