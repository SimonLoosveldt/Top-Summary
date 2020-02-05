using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoysWeekendTop.Model
{
    public class BoysWeekendContext : DbContext
    {
        public DbSet<Boy> Boys { get; set; }
        public DbSet<Girl> Girls { get; set; }
        public DbSet<Top> Tops { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=boysweekend.db");
    }
}
