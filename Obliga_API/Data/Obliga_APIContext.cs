using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Obliga_API.Model;

namespace Obliga_API.Data
{
    public class Obliga_APIContext : DbContext
    {
        public Obliga_APIContext (DbContextOptions<Obliga_APIContext> options)
            : base(options)
        {
        }

        public DbSet<Obliga_API.Model.People> People { get; set; } = default!;
    }
}
