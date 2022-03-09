using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KonusarakOgren.DAL.Contexts
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {



        }

      

    }
}
