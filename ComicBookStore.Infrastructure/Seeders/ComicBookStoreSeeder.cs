
using ComicBookStore.Domain.Entities;
using ComicBookStore.Infrastructure.Persistence;

namespace ComicBookStore.Infrastructure.Seeders;

internal class ComicBookStoreSeeder : IComicBookStoreSeeder
{
    private ComicBookStoreDbContext _dbContext;

    public ComicBookStoreSeeder(ComicBookStoreDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task Seed()
    {
        if (await _dbContext.Database.CanConnectAsync())
        {
            if (!_dbContext.ComicBooks.Any())
            {
                var publishers = GetPublishers();
                var authors = GetAuthors();
                var comicbooks = GetComicBooks();
                
                _dbContext.ComicBooks.AddRange(comicbooks);
                _dbContext.Publishers.AddRange(publishers);
                _dbContext.Authors.AddRange(authors);
                
                await _dbContext.SaveChangesAsync();
            }

        }
    }

    private List<Publisher> GetPublishers()
    {
        return new List<Publisher>
        {
            new Publisher
                {
                    Id = 20003,
                    Name = "Image",
                    Description = "Image Comics",
                    Website = "https://www.imagecomics.com",
                },
            new Publisher
                {
                    Id = 20004,
                    Name = "Dark Horse",
                    Description = "Dark Horse Comics",
                    Website = "https://www.darkhorse.com",
                },
            new Publisher
                {
                    Id = 20005,
                    Name = "Oni Press",
                    Description = "Oni Press",
                    Website = "https://www.onipress.com",
                },
        };
    }

    private List<Author> GetAuthors()
    {
        return new List<Author>
        {
            new Author
            {
                Id = 30005,
                FirstName = "Frank",
                LastName = "Miller",
            },
            new Author
            {
                Id = 30006,
                FirstName = "Art",
                LastName = "Spiegelman",
            },
            new Author
            {
                Id = 30007,
                FirstName = "Grant",
                LastName = "Morrison",
            },
            new Author
            {
                Id = 30008,
                FirstName = "Jack",
                LastName = "Kirby",
            },
        };
    }

    private List<ComicBook> GetComicBooks()
    {
        var publishers = GetPublishers();
        var authors = GetAuthors();

        var comicbooks = new List<ComicBook>
        {
            new ComicBook
            {
                Id = 10001,
                Title = "Astonish X-Men v3",
                IssueNumber = "10",
                PublisherId = 20001,
                Publisher = new Publisher
                {
                    Id = 20001,
                    Name = "Marvel",
                    Description = "Marvel Comics",
                    Website = "https://www.marvel.com",
                },
                Genre = "Action",
                Price = 100,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris dignissim leo sed nibh rutrum malesuada.",
                Condition = "CGC 9.4",
                Authors = new List<Author>
                {
                    new Author
                    {
                        Id = 30001,
                        FirstName = "Joss",
                        LastName = "Whedon",
                    },
                    new Author
                    {
                        Id = 30002,
                        FirstName = "John",
                        LastName = "Cassaday",
                    },
                }
            },
            new ComicBook
            {
                Id = 10002,
                Title = "Superman v2",
                IssueNumber = "75",
                PublisherId = 20002,
                Publisher = new Publisher
                {
                    Id = 20002,
                    Name = "DC",
                    Description = "DC Comics",
                    Website = "https://www.dccomics.com",
                },
                Genre = "Action",
                Price = 25,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris dignissim leo sed nibh rutrum malesuada.",
                Condition = "CGC 9.8",
                Authors = new List<Author>
                {
                    new Author
                    {
                        Id = 30003,
                        FirstName = "Dan",
                        LastName = "Jurgens",
                    },
                    new Author
                    {
                        Id = 30004,
                        FirstName = "Brett",
                        LastName = "Breeding",
                    },
                }
            }
        };

        return comicbooks;
    }
}
