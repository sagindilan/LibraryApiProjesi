using LibraryApiProjesi.Data;
using LibraryApiProjesi.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApiProjesi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PublisherController : BaseController<Publishers, ApplicationContext>
{
    public PublisherController(ApplicationContext context) : base(context)
    {
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Publishers>>> GetPublishers()
    {
        return await GetAll();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Publishers>> GetPublisher(int id)
    {
        return await GetById(id);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutPublisher(int id, Publishers publisher)
    {
        return await PutEntity(id, publisher);
    }

    [HttpPost]
    public async Task<ActionResult<Publishers>> PostPublisher(Publishers publisher)
    {
        return await PostEntity(publisher);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePublisher(int id)
    {
        return await DeleteEntity(id);
    }
}