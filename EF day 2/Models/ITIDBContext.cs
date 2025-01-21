using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_day_2.Models
{
    public class ITIDBContext : DbContext
    {
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Track> Tracks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=JAWAD-HAMDAN;Database=EFDay2;Trusted_Connection=True;Encrypt=False;");
        }

    }
}
