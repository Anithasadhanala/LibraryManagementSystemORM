using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Models;
using Microsoft.Extensions.Logging;


namespace LibraryManagementSystem.Data
{ 
    internal class AppDbContext : DbContext

    {

        // DB connection string
        private string connection = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=HRMS; Integrated Security=True";

        // mapping EMployee table to the Employee class. and in the project we named it as Employees
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder
              .UseSqlServer("Your_Connection_String")
              .LogTo(Console.WriteLine, LogLevel.Information) // logs SQL to console
              .EnableSensitiveDataLogging();

            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connection);
        }

    }
}
