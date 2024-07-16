using LibraryApiProjesi.Data;
using LibraryApiProjesi.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApiProjesi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BooksController : BaseController<Books, ApplicationContext>
{
    public BooksController(ApplicationContext context) : base(context)
    {
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Books>>> GetBooks()
    {
        return await GetAll();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Books>> GetBook(int id)
    {
        return await GetById(id);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutBook(int id, Books book)
    {
        return await PutEntity(id, book);
    }

    [HttpPost]
    public async Task<ActionResult<Books>> PostBook(Books book)
    {
        return await PostEntity(book);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteBook(int id)
    {
        return await DeleteEntity(id);
    }
}