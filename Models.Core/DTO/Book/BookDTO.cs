using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Core.DTO.Book
{
    public class BookDTO
    {
        public required string BookName { get; set; }
        public DateTime PublichDate { get; set; }
        public required string AuthorId { get; set; }
    }
}
