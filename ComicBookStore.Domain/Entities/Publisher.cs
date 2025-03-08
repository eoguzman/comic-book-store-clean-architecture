namespace ComicBookStore.Domain.Entities;

public class Publisher
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public string? Website { get; set;}
}
