using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDBApp
{
    public class Book
    {
        [Key]
        public string ISBN { get; set; }
        public string BookTitle { get; set; }
        //[ForeignKey("Author")]
        //public Author AuthorID { get; set; }
        public int Pages { get; set; }
        public string Genre { get; set; }
    }
}
