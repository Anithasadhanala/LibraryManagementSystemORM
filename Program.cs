
using LibraryManagementSystem.Models;
using LibraryManagementSystem.Services;
using System.Reflection;
using static System.Reflection.Metadata.BlobBuilder;
// add books to authors | list the books with authors | update a book title, | delete a book

Console.WriteLine("Hello, World!");



//string name = Console.ReadLine();
//string email = Console.ReadLine();

var author = new AuthorService();
//author.InsertSingleRecord(name,email);



//var author_with_books = new Author
//{
//    Name = "sai",
//    Email = "google@solera.com",

//    Books = new List<Book>
//   {
//       new Book
//       {
//           Title = "You can win",
//           YearPublished = 123,
//       }
//   }
//};


//author.InsertAuthorWithBooks(author_with_books);
//Console.WriteLine("Done !!!!");


var book_obj = new BookService();
//var books = book_obj.FetchBooksWithAuthors();

//foreach (var book in books)
//{
//    Console.WriteLine($"Book: {book.Title}, Year: {book.YearPublished}");
//    Console.WriteLine($"  Author: {book.Author.Name}, Email: {book.Author.Email}");
//}


//book_obj.UpdateBookTitle(1, "hii");


book_obj.DeleteABook(1);
