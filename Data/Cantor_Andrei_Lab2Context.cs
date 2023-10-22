using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cantor_Andrei_Lab2.Models;

namespace Cantor_Andrei_Lab2.Data
{
    public class Cantor_Andrei_Lab2Context : DbContext
    {
        public Cantor_Andrei_Lab2Context (DbContextOptions<Cantor_Andrei_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Cantor_Andrei_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Cantor_Andrei_Lab2.Models.Publisher>? Publisher { get; set; }
    }
}
