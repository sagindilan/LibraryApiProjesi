using System.ComponentModel.DataAnnotations;
namespace LibraryApiProjesi.Models;
	public class Languages
	{
        [Key]
        public string Code { get; set; } = "";

        public string Name { get; set; } = "";

        public List<Books>? Books { get; set; }
    }