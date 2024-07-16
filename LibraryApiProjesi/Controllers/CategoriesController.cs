using LibraryApiProjesi.Data;
using LibraryApiProjesi.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApiProjesi.Controllers;
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : BaseController<Categories, ApplicationContext>
    {
        public CategoriesController(ApplicationContext context) : base(context)
        {
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Categories>>> GetCategories()
        {
            return await GetAll();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Categories>> GetCategory(short id)
        {
            return await GetById(id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategory(short id, Categories category)
        {
            return await PutEntity(id, category);
        }

        [HttpPost]
        public async Task<ActionResult<Categories>> PostCategory(Categories category)
        {
            return await PostEntity(category);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(short id)
        {
            return await DeleteEntity(id);
        }
    }