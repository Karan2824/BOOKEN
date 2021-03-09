using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BOOKEN.Model;

namespace BOOKEN.Data
{
    public class BOOKENContext : DbContext
    {
        public BOOKENContext (DbContextOptions<BOOKENContext> options)
            : base(options)
        {
        }

        public DbSet<BOOKEN.Model.Customer> Customer { get; set; }

        public DbSet<BOOKEN.Model.Book> Book { get; set; }

        public DbSet<BOOKEN.Model.Author> Author { get; set; }
    }
}
