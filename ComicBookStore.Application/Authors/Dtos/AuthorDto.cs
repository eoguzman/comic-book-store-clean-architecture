using ComicBookStore.Application.ComicBooks.Dtos;
using ComicBookStore.Domain.Entities;
using System.Data;

namespace ComicBookStore.Application.Authors.Dtos;

public class AuthorDto
{
    public int Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }

    public static AuthorDto? FromEntity (Author? author)
    {
        if (author == null)
        {
            return null;
        }

        return new AuthorDto()
        {
            Id = author.Id,
            FirstName = author.FirstName,
            LastName = author.LastName
        };
    }
}
