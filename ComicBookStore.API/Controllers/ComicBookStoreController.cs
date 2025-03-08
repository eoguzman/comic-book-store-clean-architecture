using ComicBookStore.Application.Authors;
using ComicBookStore.Application.ComicBooks;
using ComicBookStore.Application.ComicBooks.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace ComicBookStore.API.Controllers;

[ApiController]
[Route("api/comicbookstore/")]
public class ComicBookStoreController(IComicBooksService comicBooksService, IAuthorsService authorsService) : ControllerBase
{
    [HttpGet]
    [Route("comics")]
    public async Task<IActionResult> GetAllComicBooks()
    {
        var comics = await comicBooksService.GetAllComicBooks();
        
        return Ok(comics);
    }

    [HttpGet]
    [Route("comics/{id}")]
    public async Task<IActionResult> GetComicBookById(int id)
    {
        var comic = await comicBooksService.GetById(id);

        if(comic == null)
        {
            return NotFound(comic);
        }
        
        return Ok(comic);
    }

    [HttpPost]
    [Route("comics")]
    public async Task<IActionResult> CreateComicBook([FromBody] CreateComicBookDto createComicBookDto)
    {
        int id = await comicBooksService.Create(createComicBookDto);

        return CreatedAtAction(nameof(GetComicBookById), new { id }, null);
    }

    [HttpGet]
    [Route("authors")]
    public async Task<IActionResult> GetAllAuthors()
    {
        var authors = await authorsService.GetAllAuthors();
        
        return Ok(authors);
    }

    [HttpGet]
    [Route("authors/{id}")]
    public async Task<IActionResult> GetAuthorById(int id)
    {
        var authors = await authorsService.GetById(id);

        if(authors == null)
        {
            return NotFound(authors);
        }
        
        return Ok(authors);
    }
}
