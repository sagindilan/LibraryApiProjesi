using System;
namespace LibraryApiProjesi.Models;
	public class SubCategories
	{
		public short Id  { get; set; }
		public string Name { get; set; } = "";
		public  short CategoryId  { get; set; }
		public Categories? Category { get; set; }

		public List <Books>? Books { get; set; }
	}