using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookTracker_Context;
using BookTracker_Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;

namespace BookTracker_App.Pages
{
    public class EditBookModel : PageModel
    {
        private readonly BookContext _db;
        [FromForm]
        public Book book { get; set; }
        public EditBookModel(BookContext db)
        {
            _db = db;
        }

        public void OnGet([FromQuery] int Id)
        {
            book = _db.Books.Where(pd => pd.Id == Id).FirstOrDefault();
        }
       public void OnPost()
        {
            _db.Books.Update(book);
            _db.SaveChangesAsync();
        }
    }
}
