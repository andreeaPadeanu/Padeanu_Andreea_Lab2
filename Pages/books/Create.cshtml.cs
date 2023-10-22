using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Padeanu_Andreea_Lab2.Data;
using Padeanu_Andreea_Lab2.Models;

namespace Padeanu_Andreea_Lab2.Pages.books
{
    public class CreateModel : PageModel
    {
        private readonly Padeanu_Andreea_Lab2.Data.Padeanu_Andreea_Lab2Context _context;

        public CreateModel(Padeanu_Andreea_Lab2.Data.Padeanu_Andreea_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["PublisherID"] = new SelectList(_context.Set<Publisher>(), "ID",
"PublisherName");
            return Page();
        }

        [BindProperty]
        public book book { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.book == null || book == null)
            {
                return Page();
            }

            _context.book.Add(book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
