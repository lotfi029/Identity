using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Models.Core.Models
{
    public class Book
    {
        public string BookId { get; set; }
        public required string BookName { get; set; }    
        public DateTime PublichDate { get; set; }
        public required string AuthorId { get; set; }
        public Author? Author { get; set; }
        public Book()
        {
            BookId = new Guid().ToString();
        }
    }
}
