namespace ComicBookStore.Domain.Entities;

public class ComicBook
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string IssueNumber { get; set; }
    public int PublisherId { get; set; }
    public required Publisher Publisher { get; set; }
    public string? Genre { get; set; }
    public decimal Price { get; set; }
    public string? Description { get; set; }
    public string? Condition { get; set; }
    public ICollection<Author>? Authors { get; set; }
}
