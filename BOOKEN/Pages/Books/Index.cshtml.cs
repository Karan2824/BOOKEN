using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BOOKEN.Data;
using BOOKEN.Model;

namespace BOOKEN.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly BOOKEN.Data.BOOKENContext _context;

        public IndexModel(BOOKEN.Data.BOOKENContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Book.ToListAsync();
        }
    }
}
