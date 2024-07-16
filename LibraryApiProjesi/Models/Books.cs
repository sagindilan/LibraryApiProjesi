using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryApiProjesi.Models;
public class Books
{
    public int Id { get; set; }

    [StringLength(13, MinimumLength = 10)]
    [Column(TypeName = "varchar(13")]
    public string? ISBN { get; set; }

    [Required]
    [StringLength(2000)]
    public string Title { get; set; } = "";

    [Range(1, short.MaxValue)]
    public short PageCount { get; set; }
    public short PublishingYear { get; set; }
    public string? Description { get; set; }
    public int PrintCount { get; set; }
    public bool Banned { get; set; }
    public float Rating { get; set; }
    public int PublisherId { get; set; }
    public string LocationShelf { get; set; } = "";

    public Publishers? Publisher { get; set; }
    public List<SubCategories>? SubCategories { get; set; }
    public List<Languages>? Languages { get; set; }
    public Locations? Location { get; set; }
}