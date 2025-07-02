using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace LibraryManagementSystem.Models
{
    internal class Author
    {
        [Key]
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
