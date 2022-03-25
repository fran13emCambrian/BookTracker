using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BookTracker_Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Uri Author { get; set; }

        public string Description { get; set; }
    }
}
