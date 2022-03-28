using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BookTracker_Models
{
    public class Book
    {
        [Key]
        [Required]
        [HiddenInput]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        public string Author { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public ICollection<BookEdition> Editions { get; set; }
    }
}
