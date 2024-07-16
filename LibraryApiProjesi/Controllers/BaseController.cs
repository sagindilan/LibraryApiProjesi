using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryApiProjesi.Controllers;
public abstract class BaseController<TEntity, OrhnContext> : ControllerBase where TEntity : class where OrhnContext : DbContext
{
    private readonly OrhnContext _context;

    public BaseController(OrhnContext context)
    {
        _context = context;
    }

    protected async Task<ActionResult<IEnumerable<TEntity>>> GetAll()
    {
        return await _context.Set<TEntity>().ToListAsync();
    }

    protected async Task<ActionResult<TEntity>> GetById(object id)
    {
        var entity = await _context.Set<TEntity>().FindAsync(id);
        if (entity == null)
        {
            return NotFound();
        }
        return entity;
    }

    protected async Task<IActionResult> PutEntity(object id, TEntity entity)
    {
        _context.Entry(entity).State = EntityState.Modified;
        try
        {
            await _context.SaveChangesAsync();
            return NoContent();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!await EntityExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }
    }

    protected async Task<ActionResult<TEntity>> PostEntity(TEntity entity)
    {
        _context.Set<TEntity>().Add(entity);
        await _context.SaveChangesAsync();
        return CreatedAtAction("GetById", new { id = GetPrimaryKeyValue(entity) }, entity);
    }

    protected async Task<IActionResult> DeleteEntity(object id)
    {
        var entity = await _context.Set<TEntity>().FindAsync(id);
        if (entity == null)
        {
            return NotFound();
        }
        _context.Set<TEntity>().Remove(entity);
        await _context.SaveChangesAsync();
        return NoContent();
    }

    private async Task<bool> EntityExists(object id)
    {
        return await _context.Set<TEntity>().FindAsync(id) != null;
    }

    private object GetPrimaryKeyValue(TEntity entity)
    {
        var keyName = _context.Model.FindEntityType(typeof(TEntity)).FindPrimaryKey().Properties
            .Select(x => x.Name).Single();
        return entity.GetType().GetProperty(keyName).GetValue(entity, null);
    }
}