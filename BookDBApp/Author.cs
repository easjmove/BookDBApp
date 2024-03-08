﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDBApp
{
    public class Author
    {
        [Column("AuthorId")]
        [Key]
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
    }
}
