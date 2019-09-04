using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestCalculator.Model
{
    public class TestProjectDbContext : DbContext
    {
        public TestProjectDbContext(DbContextOptions<TestProjectDbContext> options) : base(options) { }

        public DbSet<Log> Logs { get; set; }
    }
}
