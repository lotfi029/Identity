using Models.Core.Models;
using Models.Core.Repositories;

namespace DataAccess.EF.Repositories
{
    public class BookRepository(AppDbContext context) : BaseRepository<Book>(context), IBookRepository
    {
        private readonly AppDbContext _context = context;

    }
}
