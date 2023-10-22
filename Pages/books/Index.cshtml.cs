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
    public class IndexModel : PageModel
    {
        private readonly Padeanu_Andreea_Lab2.Data.Padeanu_Andreea_Lab2Context _context;

        public IndexModel(Padeanu_Andreea_Lab2.Data.Padeanu_Andreea_Lab2Context context)
        {
            _context = context;
        }

        public IList<book> book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            book = await _context.book
            .Include(b => b.Publisher)
            .ToListAsync();
        }

    }
}
