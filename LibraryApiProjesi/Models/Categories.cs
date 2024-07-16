namespace LibraryApiProjesi.Models;
public class Categories
{
    public short Id { get; set; }
    public string Name { get; set; } = "";


    public List<SubCategories>? SubCategories { get; set; }


}