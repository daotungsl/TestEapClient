using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TestEapClient.Models
{
    public class TestEapClientContext : DbContext
    {
        public TestEapClientContext (DbContextOptions<TestEapClientContext> options)
            : base(options)
        {
        }

        public DbSet<TestEapClient.Models.Employee> Employee { get; set; }
    }
}
