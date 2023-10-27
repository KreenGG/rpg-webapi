using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace rpg.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Character> Characters => Set<Character>();
        public DbSet<User> Users => Set<User>();
    }
}