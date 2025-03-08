using ComicBookStore.Application.Authors.Dtos;

namespace ComicBookStore.Application.Authors;

public interface IAuthorsService
{
    Task<IEnumerable<AuthorDto>> GetAllAuthors();
    Task<AuthorDto?> GetById(int id);
}
