using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookTracker_Context;
using BookTracker_Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookTracker_App.Pages
{
    public class AddEditionModel : PageModel
    {
        private readonly BookContext _db;

        public IList<SelectListItem>BookList {get; set;}

        [FromForm]
        public BookEdition edition { get; set; }
        

        public AddEditionModel(BookContext ctx)
        {
            _db = ctx;
           BookList = _db.Books.Select(pod => new SelectListItem(pod.Title, pod.Id.ToString())).ToList();
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
