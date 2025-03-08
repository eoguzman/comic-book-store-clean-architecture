using ComicBookStore.Domain.Entities;
using ComicBookStore.Domain.Repositories;
using ComicBookStore.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ComicBookStore.Infrastructure.Repositories;

internal class ComicBooksRepository : IComicBooksRepository
{
    private ComicBookStoreDbContext _dbContext;

    public ComicBooksRepository(ComicBookStoreDbContext dbContext)
    {
        _dbContext = dbContext;        
    }

    public async Task<int> CreateAsync(ComicBook entity)
    {
        _dbContext.ComicBooks.Add(entity);
        await _dbContext.SaveChangesAsync();

        return entity.Id;

    }

    public async Task<IEnumerable<ComicBook>> GetAllAsync()
    {
        return await _dbContext.ComicBooks
            .Include(p => p.Publisher)
            .Include(a => a.Authors)
            .ToListAsync();
    }

    public async Task<ComicBook?> GetByIdAsync(int id)
    {
        return await _dbContext.ComicBooks
            .Include(p => p.Publisher)
            .Include(a => a.Authors)
            .FirstOrDefaultAsync(comic => comic.Id == id);
    }
}
