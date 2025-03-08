using ComicBookStore.Application.Authors;
using ComicBookStore.Application.ComicBooks;
using Microsoft.Extensions.DependencyInjection;

namespace ComicBookStore.Application.Extensions;

public static class ServiceCollectionExtension
{
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IComicBooksService, ComicBooksService>();
        services.AddScoped<IAuthorsService, AuthorsService>();
    }
}