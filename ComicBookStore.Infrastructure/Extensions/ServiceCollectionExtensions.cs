using Microsoft.Extensions.DependencyInjection;
using ComicBookStore.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using ComicBookStore.Domain.Repositories;
using ComicBookStore.Infrastructure.Repositories;
using ComicBookStore.Infrastructure.Seeders;

namespace ComicBookStore.Infrastructure.Extensions;
public static class ServiceCollectionExtensions
{
     public static void AddInfrastructure(this IServiceCollection services)
    {
        services.AddDbContext<ComicBookStoreDbContext>(options => options.UseInMemoryDatabase(databaseName: "ComicBookStoreDb"));

        services.AddScoped<IComicBookStoreSeeder, ComicBookStoreSeeder>();

        services.AddScoped<IComicBooksRepository, ComicBooksRepository>();
        services.AddScoped<IAuthorsRepository, AuthorsRepository>();

    }
}
