using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BOOKEN.Data;
using BOOKEN.Model;

namespace BOOKEN.Pages.Authors
{
    public class DetailsModel : PageModel
    {
        private readonly BOOKEN.Data.BOOKENContext _context;

        public DetailsModel(BOOKEN.Data.BOOKENContext context)
        {
            _context = context;
        }

        public Author Author { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Author = await _context.Author
                .Include(a => a.Customer).FirstOrDefaultAsync(m => m.Id == id);

            if (Author == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
