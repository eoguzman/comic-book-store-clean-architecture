using ComicBookStore.Domain.Entities;

namespace ComicBookStore.Domain.Repositories;

public interface IComicBooksRepository
{
    Task<IEnumerable<ComicBook>> GetAllAsync();
    Task<ComicBook?> GetByIdAsync(int id);
    Task<int> CreateAsync(ComicBook comicBook);

}
