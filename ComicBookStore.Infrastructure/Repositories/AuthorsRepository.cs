using ComicBookStore.Domain.Entities;
using ComicBookStore.Domain.Repositories;
using ComicBookStore.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ComicBookStore.Infrastructure.Repositories;

internal class AuthorsRepository : IAuthorsRepository
{
    private ComicBookStoreDbContext _dbContext;

    public AuthorsRepository(ComicBookStoreDbContext dbContext)
    {
        _dbContext = dbContext;        
    }

    public async Task<IEnumerable<Author>> GetAllAsync()
    {
        return await _dbContext.Authors.ToListAsync();
    }

    public async Task<Author?> GetByIdAsync(int id)
    {
        return await _dbContext.Authors
            .FirstOrDefaultAsync(author => author.Id == id);
    }
}
