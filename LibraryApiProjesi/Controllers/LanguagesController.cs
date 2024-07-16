using LibraryApiProjesi.Data;
using LibraryApiProjesi.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApiProjesi.Controllers;
    [Route("api/[controller]")]
    [ApiController]
    public class LanguagesController : BaseController<Languages, ApplicationContext>
    {
        public LanguagesController(ApplicationContext context) : base(context)
        {
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Languages>>> GetLanguages()
        {
            return await GetAll();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Languages>> GetLanguage(string id)
        {
            return await GetById(id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutLanguage(string id, Languages language)
        {
            return await PutEntity(id, language);
        }

        [HttpPost]
        public async Task<ActionResult<Languages>> PostLanguage(Languages language)
        {
            return await PostEntity(language);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLanguage(string id)
        {
            return await DeleteEntity(id);
        }
    }