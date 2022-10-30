using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageDBSave.DB
{
    public class MyContext : DbContext
    {
        private string ConnectionString =
            "server=***; database=***; user=***; password=***; timeout=30;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        public DbSet<User>Users {get;set;}
        public DbSet<UserImage>Images { get; set; }
    }
}
