using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie_Kaluta.Models;

namespace MvcMovie_Kaluta.Data
{
    public class MvcMovie_KalutaContext : DbContext
    {
        public MvcMovie_KalutaContext (DbContextOptions<MvcMovie_KalutaContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie_Kaluta.Models.Movie> Movie { get; set; } = default!;
    }
}
