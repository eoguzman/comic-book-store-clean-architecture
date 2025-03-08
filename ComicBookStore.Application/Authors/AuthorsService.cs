using ComicBookStore.Application.Authors.Dtos;
using ComicBookStore.Domain.Repositories;

namespace ComicBookStore.Application.Authors;

internal class AuthorsService(IAuthorsRepository authorsRepository) : IAuthorsService
{
    public async Task<IEnumerable<AuthorDto>> GetAllAuthors()
    {
        var authors = await authorsRepository.GetAllAsync();

        return authors.Select(AuthorDto.FromEntity)!;
    }

    public async Task<AuthorDto?> GetById(int id)
    {
        var author = await authorsRepository.GetByIdAsync(id);

        return AuthorDto.FromEntity(author);
    }
}
