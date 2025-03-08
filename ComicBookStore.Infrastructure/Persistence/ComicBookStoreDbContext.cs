using Microsoft.EntityFrameworkCore;
using ComicBookStore.Domain.Entities;


namespace ComicBookStore.Infrastructure.Persistence;

internal class ComicBookStoreDbContext(DbContextOptions<ComicBookStoreDbContext> options) : DbContext(options)
{
    internal DbSet<ComicBook> ComicBooks { get; set; }
    internal DbSet<Author> Authors { get; set; }
    internal DbSet<Publisher> Publishers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Publisher <=> ComicBook
        modelBuilder.Entity<ComicBook>()
            .HasOne(c => c.Publisher)
            //.WithMany(p => p.ComicBooks)
            //.HasForeignKey(c => c.PublisherId)
            ;

        modelBuilder.Entity<ComicBook>()
            .HasMany(c => c.Authors)
            //.WithMany(p => p.ComicBooks)
            //.HasForeignKey(c => c.PublisherId)
            ;
    }
}
