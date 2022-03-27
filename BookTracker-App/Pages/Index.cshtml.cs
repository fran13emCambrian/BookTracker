using BookTracker_Context;
using BookTracker_Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookTracker_App.Pages
{   
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly  BookContext _db;   

        public ICollection<Book> Books { get; set; }
         
        public IndexModel(ILogger<IndexModel> logger, BookContext db)
        {
            _logger = logger;
            _db = db;
            _logger.LogInformation("lajsdlfjasdjf");
        }

        public void OnGet()
        {
         ViewData["numBooks"] = _db.Books.Count();
            var bookQuery = _db.Books.Select(pd => pd);
            Books = bookQuery.ToList();
        }
    }
}
