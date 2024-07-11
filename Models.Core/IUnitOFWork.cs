using Models.Core.Repositories;

namespace Models.Core
{
    public interface IUnitOFWork : IDisposable
    {
        
        IAuthorRepository Author { get; }
        IBookRepository Book { get; }
        int Save();

    }
}
