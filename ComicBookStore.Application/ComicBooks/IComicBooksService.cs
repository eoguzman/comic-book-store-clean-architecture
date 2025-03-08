using ComicBookStore.Application.ComicBooks.Dtos;

namespace ComicBookStore.Application.ComicBooks;

public interface IComicBooksService
{
    Task<IEnumerable<ComicBookDto>> GetAllComicBooks();
    Task<ComicBookDto?> GetById(int id);
    Task<int> Create(CreateComicBookDto dto);
}