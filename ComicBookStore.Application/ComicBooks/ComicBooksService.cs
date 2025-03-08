using ComicBookStore.Application.ComicBooks.Dtos;
using ComicBookStore.Domain.Entities;
using ComicBookStore.Domain.Repositories;

namespace ComicBookStore.Application.ComicBooks;

internal class ComicBooksService(IComicBooksRepository comicBooksRepository) : IComicBooksService
{
    public async Task<IEnumerable<ComicBookDto>> GetAllComicBooks()
    {
        var comicBooks = await comicBooksRepository.GetAllAsync();

        return comicBooks.Select(ComicBookDto.FromEntity)!;
    }

    public async Task<ComicBookDto?> GetById(int id)
    {
        var comicBook = await comicBooksRepository.GetByIdAsync(id);

        return ComicBookDto.FromEntity(comicBook);
    }

    public async Task<int> Create(CreateComicBookDto dto)
    {
        var comicBook = CreateComicBookDto.ToEntity(dto);
        
        return await comicBooksRepository.CreateAsync(comicBook);
    }
}
