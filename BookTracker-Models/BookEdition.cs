using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTracker_Models
{
    public class BookEdition
    {
        [Key]
        [Required]
        [HiddenInput]

        public int Id { get; set; }

        [Required]

        public string Author { get; set; }
        [Required]
        public string Title { get; set; }

        public string Year { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name ="Show little Synopsis")]
        public string Synopsis { get; set; }

        [ForeignKey("Book")]
        [Display(Name = "Book")]
        public int BookId { get; set; }

        public Book Book { get; set; }
    }
}
