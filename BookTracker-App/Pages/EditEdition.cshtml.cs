using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookTracker_Context;
using BookTracker_Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookTracker_App.Pages
{
    public class EditEditionModel : PageModel
    {
        private readonly BookContext _db;

        [FromForm]
        public BookEdition edition { get; set; }

        public EditEditionModel(BookContext ctx)
        {
            _db = ctx;
        }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            _db.Add<BookEdition>(edition);
            _db.SaveChangesAsync();
        }
    }
}
