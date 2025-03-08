using ComicBookStore.Application.Authors.Dtos;
using ComicBookStore.Domain.Entities;

namespace ComicBookStore.Application.ComicBooks.Dtos;

public class ComicBookDto
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string IssueNumber { get; set; }
    public int PublisherId { get; set; }
    public required string PublisherName { get; set; }
    public string? Genre { get; set; }
    public decimal Price { get; set; }
    public string? Description { get; set; }
    public string? Condition { get; set; }
    public ICollection<AuthorDto>? Authors { get; set; }

    public static ComicBookDto? FromEntity (ComicBook? comicBook)
    {
        if (comicBook == null)
        {
            return null;
        }

        return new ComicBookDto()
        {
            Id = comicBook.Id,
            Title = comicBook.Title,
            IssueNumber = comicBook.IssueNumber,
            PublisherId = comicBook.Publisher.Id,
            PublisherName = comicBook.Publisher.Name,
            Genre = comicBook.Genre,
            Price = comicBook.Price,
            Description = comicBook.Description,
            Condition = comicBook.Condition,
            Authors = comicBook.Authors.Select(AuthorDto.FromEntity).ToList()
        };
    }
}
