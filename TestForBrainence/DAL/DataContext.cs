using DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace DAL
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }

        public DbSet<Sentences> Sentences { get; set; }
    }
}
