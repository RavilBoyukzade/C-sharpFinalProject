using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Library.Models;

namespace Library.Data
{
    public class LibraryDbContext:DbContext
    {
        public LibraryDbContext() : base("LibraryDbContext")
        {

        }

        public DbSet<User>Users { get; set; }
        public DbSet<Person>Persons { get; set; }
        public DbSet<Book>Books { get; set; }
    }
}
