using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Padeanu_Andreea_Lab2.Models;

namespace Padeanu_Andreea_Lab2.Data
{
    public class Padeanu_Andreea_Lab2Context : DbContext
    {
        public Padeanu_Andreea_Lab2Context (DbContextOptions<Padeanu_Andreea_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Padeanu_Andreea_Lab2.Models.book> book { get; set; } = default!;

        public DbSet<Padeanu_Andreea_Lab2.Models.Publisher>? Publisher { get; set; }
    }
}
