using LibraryApiProjesi.Data;
using LibraryApiProjesi.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApiProjesi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class LocationsController : BaseController<Locations, ApplicationContext>
{
    public LocationsController(ApplicationContext context) : base(context)
    {
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Locations>>> GetLocations()
    {
        return await GetAll();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Locations>> GetLocation(string id)
    {
        return await GetById(id);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutLocation(string id, Locations location)
    {
        return await PutEntity(id, location);
    }

    [HttpPost]
    public async Task<ActionResult<Locations>> PostLocation(Locations location)
    {
        return await PostEntity(location);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteLocation(string id)
    {
        return await DeleteEntity(id);
    }
}
    