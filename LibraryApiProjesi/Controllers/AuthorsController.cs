using LibraryApiProjesi.Data;
using LibraryApiProjesi.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApiProjesi.Controllers;
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : BaseController<Authors, ApplicationContext>
    {
        public AuthorsController(ApplicationContext context) : base(context)
        {
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Authors>>> GetAuthors()
        {
            return await GetAll();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Authors>> GetAuthor(long id)
        {
            return await GetById(id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAuthor(long id, Authors author)
        {
            return await PutEntity(id, author);
        }

        [HttpPost]
        public async Task<ActionResult<Authors>> PostAuthor(Authors author)
        {
            return await PostEntity(author);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAuthor(long id)
        {
            return await DeleteEntity(id);
        }
    }