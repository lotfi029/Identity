using Models.Core.Models;
using Models.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EF.Repositories
{
    public class AuthorRepository(AppDbContext context) : BaseRepository<Author>(context), IAuthorRepository
    {
        private readonly AppDbContext _context = context;

    }
}
