using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Padeanu_Andreea_Lab2.Data;
using Padeanu_Andreea_Lab2.Models;

namespace Padeanu_Andreea_Lab2.Pages.books
{
    public class DeleteModel : PageModel
    {
        private readonly Padeanu_Andreea_Lab2.Data.Padeanu_Andreea_Lab2Context _context;

        public DeleteModel(Padeanu_Andreea_Lab2.Data.Padeanu_Andreea_Lab2Context context)
        {
            _context = context;
        }

        [BindProperty]
      public book book { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.book == null)
            {
                return NotFound();
            }

            var book = await _context.book.FirstOrDefaultAsync(m => m.ID == id);

            if (book == null)
            {
                return NotFound();
            }
            else 
            {
                book = book;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.book == null)
            {
                return NotFound();
            }
            var book = await _context.book.FindAsync(id);

            if (book != null)
            {
                book = book;
                _context.book.Remove(book);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
