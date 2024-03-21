using ModelsAndDBcontext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ModelsAndDBcontext
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseMySQL("Server=localhost;Port=3306;Database=it_kariera_project;user=root;password=nadenica12;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(book =>
            {
                book.ToTable("Books");
                book.HasKey(p => p.Id);
            });
        }

        public DbSet<Book> Books { get; set; }
  
    }
}

