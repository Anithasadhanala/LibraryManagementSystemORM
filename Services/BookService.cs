using Microsoft.EntityFrameworkCore.Metadata.Internal;
using LibraryManagementSystem.Data;
using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace LibraryManagementSystem.Services
{
    internal class BookService
    {

        public List<Book> FetchBooksWithAuthors()
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var books = context.Books.Include(a => a.Author).ToList();
                    return books;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public void UpdateBookTitle(int id,string title)
        {
            try
            {
                using (var context = new AppDbContext()) {
                    var book_obj = context.Books.Find(id);
                    if (book_obj!= null) {
                        book_obj.Title = title;
                        context.SaveChanges();
                    }
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

        }

        public void DeleteABood(int id)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var book_obj = context.Books.Find(id);
                    if (book_obj != null)
                    {
                        context.Books.Remove(book_obj);
                        context.SaveChanges();
                    }
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
