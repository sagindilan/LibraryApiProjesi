using LibraryApiProjesi.Models;
using Microsoft.EntityFrameworkCore;


namespace LibraryApiProjesi.Data;
public class ApplicationContext : DbContext
{
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {

    }

    public DbSet<Locations>? Locations { get; set; }
    public DbSet<Languages>? Languages { get; set; }
    public DbSet<Categories>? Categories { get; set; }
    public DbSet<SubCategories>? SubCategories { get; set; }
    public DbSet<Publishers>? Publishers { get; set; }
    public DbSet<Authors>? Authors { get; set; }
    public DbSet<Books>? Books { get; set; }

}