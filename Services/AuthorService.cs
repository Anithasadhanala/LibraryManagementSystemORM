using LibraryManagementSystem.Data;
using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Services
{
    internal class AuthorService
    {
        // Insert single into the Authors Table
        public void InsertSingleRecord(string Name, string Email)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    context.Authors.Add(new Author { Name = Name, Email = Email });
                    context.SaveChanges();
                    Console.WriteLine("Author inserted Successfully");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        // Insert Authors and Books at a time as they are related
        public void InsertAuthorWithBooks(Author obj)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    context.Authors.Add(obj);
                    context.SaveChanges();
                    Console.WriteLine("Author with Books inserted Successfully");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
