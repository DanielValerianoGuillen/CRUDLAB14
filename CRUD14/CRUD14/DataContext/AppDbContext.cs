using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD14
{
    public class AppDbContext : DbContext
    {
        string DbPath = string.Empty;
        public DbSet<Student> People { get; set; }
        public AppDbContext(string dbPath)
        {
            this.DbPath = dbPath;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={DbPath}");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Student).Assembly);
        }
    }
}
