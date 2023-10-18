using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AndresGuaman_EjercicioCF.Models;

namespace AndresGuaman_EjercicioCF.Data
{
    public class AndresGuaman_EjercicioCFContext : DbContext
    {
        public AndresGuaman_EjercicioCFContext (DbContextOptions<AndresGuaman_EjercicioCFContext> options)
            : base(options)
        {
        }

        public DbSet<AndresGuaman_EjercicioCF.Models.Burger> Burger { get; set; } = default!;
        public DbSet<AndresGuaman_EjercicioCF.Models.Promo> Promo { get; set; }
    }
}
