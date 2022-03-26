using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BookTracker_Context;
using BookTracker_Models;

namespace BookTracker_App.Pages
{
    public class AddBookModel : PageModel
    {
        private readonly BookContext _db;

        [FromForm]
        public Book book { get; set; }

        public AddBookModel(BookContext db)
        {
            _db = db;
        }
        public void OnGet()
        {

        }

        public void OnPost()
        {
            _db.Add<Book>(book);
         _db.SaveChangesAsync();
        }
    }
}
