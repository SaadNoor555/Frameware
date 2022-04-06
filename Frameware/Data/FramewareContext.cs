#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Frameware.Model;

namespace Frameware.Data
{
    public class FramewareContext : DbContext
    {
        public FramewareContext (DbContextOptions<FramewareContext> options)
            : base(options)
        {
        }

        public DbSet<Frameware.Model.Student> Student { get; set; }
    }
}
