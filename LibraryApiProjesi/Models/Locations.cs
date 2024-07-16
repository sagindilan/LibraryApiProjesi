using System;
using System.ComponentModel.DataAnnotations;

namespace LibraryApiProjesi.Models;
public class Locations
{
    [Key]
    public string Shelf { get; set; } = "";
    public List<Books>? Books { get; set; }

}