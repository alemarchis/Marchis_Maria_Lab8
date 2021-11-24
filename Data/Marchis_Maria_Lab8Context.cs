using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Marchis_Maria_Lab8.Models;

namespace Marchis_Maria_Lab8.Data
{
    public class Marchis_Maria_Lab8Context : DbContext
    {
        public Marchis_Maria_Lab8Context (DbContextOptions<Marchis_Maria_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Marchis_Maria_Lab8.Models.Book> Book { get; set; }

        public DbSet<Marchis_Maria_Lab8.Models.Publisher> Publisher { get; set; }
    }
}
