using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using L2Ex2.Models;

namespace L2Ex2.Data
{
    public class L2Ex2Context : DbContext
    {
        public L2Ex2Context (DbContextOptions<L2Ex2Context> options)
            : base(options)
        {
        }

        public DbSet<L2Ex2.Models.Reservations> Reservations { get; set; } = default!;
    }
}
