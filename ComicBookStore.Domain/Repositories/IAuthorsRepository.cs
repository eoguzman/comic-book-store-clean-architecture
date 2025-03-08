using ComicBookStore.Domain.Entities;

namespace ComicBookStore.Domain.Repositories;

public interface IAuthorsRepository
{
    public Task<IEnumerable<Author>> GetAllAsync();
    public Task<Author?> GetByIdAsync(int id);
}
