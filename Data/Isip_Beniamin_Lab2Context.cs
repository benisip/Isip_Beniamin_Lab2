using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Isip_Beniamin_Lab2.Models;

namespace Isip_Beniamin_Lab2.Data
{
    public class Isip_Beniamin_Lab2Context : DbContext
    {
        public Isip_Beniamin_Lab2Context (DbContextOptions<Isip_Beniamin_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Isip_Beniamin_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Isip_Beniamin_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Isip_Beniamin_Lab2.Models.Author> Author { get; set; } = default!;
    }
}
