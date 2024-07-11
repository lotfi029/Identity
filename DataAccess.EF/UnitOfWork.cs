using DataAccess.EF.Repositories;
using Microsoft.EntityFrameworkCore;
using Models.Core;
using Models.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EF
{
    public class UnitOfWork : IUnitOFWork
    {
        private readonly AppDbContext _dbContext;
        private IAuthorRepository _authorRepository;
        public IBookRepository _bookRepository;
        public UnitOfWork(AppDbContext context)
        {
            _dbContext = context;
        }
        public IAuthorRepository Author
        {
            get
            {
                if (_authorRepository == null)
                    _authorRepository = new AuthorRepository(_dbContext);
                return _authorRepository;
            }
        }
        public IBookRepository Book
        {
            get
            {
                if (_bookRepository == null)
                    _bookRepository = new BookRepository(_dbContext);
                return _bookRepository;
            }
        }
        
        
    
        public int Save()
        {
            return _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
