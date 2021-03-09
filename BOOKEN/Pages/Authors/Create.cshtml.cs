using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BOOKEN.Data;
using BOOKEN.Model;

namespace BOOKEN.Pages.Authors
{
    public class CreateModel : PageModel
    {
        private readonly BOOKEN.Data.BOOKENContext _context;

        public CreateModel(BOOKEN.Data.BOOKENContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CustomerID"] = new SelectList(_context.Customer, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Author Author { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Author.Add(Author);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
