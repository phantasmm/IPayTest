using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using IPay88Q2_4API.Models;

namespace IPay88Q2_4API.DataAccess
{
    public class IPayContext : DbContext
    {
        public IPayContext(DbContextOptions options) : base(options) { }
        public DbSet<Student> Student { get; set; }
        public DbSet<Friend> Friend { get; set; }
        public DbSet<Packages> Packages { get; set; }
        public DbSet<Occupations> Occupations { get; set; }
        public DbSet<Bank> Bank { get; set; }
    }
}
