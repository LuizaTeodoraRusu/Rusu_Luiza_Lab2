using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rusu_Luiza_Lab2.Models;

namespace Rusu_Luiza_Lab2.Data
{
    public class Rusu_Luiza_Lab2Context : DbContext
    {
        public Rusu_Luiza_Lab2Context (DbContextOptions<Rusu_Luiza_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Rusu_Luiza_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Rusu_Luiza_Lab2.Models.Publisher>? Publisher { get; set; }
    }
}
