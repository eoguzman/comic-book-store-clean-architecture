using ComicBookStore.Application.Authors.Dtos;
using ComicBookStore.Domain.Entities;

namespace ComicBookStore.Application.ComicBooks.Dtos;

public class CreateComicBookDto
{
    public required string Title { get; set; }
    public required string IssueNumber { get; set; }
    public int PublisherId { get; set; }
    public required string PublisherName { get; set; }
    public string? Genre { get; set; }
    public decimal Price { get; set; }
    public string? Description { get; set; }
    public string? Condition { get; set; }

    public static ComicBook ToEntity (CreateComicBookDto dto)
    {
        return new ComicBook()
        {
            //Id = dto.Id,
            Title = dto.Title,
            IssueNumber = dto.IssueNumber,
            Publisher = new Publisher()
            {
                Id = dto.PublisherId,
                Name = dto.PublisherName
            },
            Genre = dto.Genre,
            Price = dto.Price,
            Description = dto.Description,
            Condition = dto.Condition,
            //Authors = comicBook.Authors!.Select(AuthorDto.FromEntity).ToList()
        };
    }
}
