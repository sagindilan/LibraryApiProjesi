using LibraryApiProjesi.Data;
using LibraryApiProjesi.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApiProjesi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class SubCategoriesController : BaseController<SubCategories, ApplicationContext>
{
    public SubCategoriesController(ApplicationContext context) : base(context)
    {
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<SubCategories>>> GetSubCategories()
    {
        return await GetAll();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<SubCategories>> GetSubCategory(short id)
    {
        return await GetById(id);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutSubCategory(short id, SubCategories subCategory)
    {
        return await PutEntity(id, subCategory);
    }

    [HttpPost]
    public async Task<ActionResult<SubCategories>> PostSubCategory(SubCategories subCategory)
    {
        return await PostEntity(subCategory);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteSubCategory(short id)
    {
        return await DeleteEntity(id);
    }
}