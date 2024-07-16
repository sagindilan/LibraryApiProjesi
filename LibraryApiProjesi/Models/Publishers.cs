namespace LibraryApiProjesi.Models;
	public class Publishers
	{
		public  int Id  { get; set; }
		public string Name { get; set; } = "";
		//KENDİME NOT NULL ATIP BELİRTMEK ESKİ YÖNTEM METHOD İÇİNDE STRİNG OR EMPTY DOĞRUSU

		public string? Phone   { get; set; }
		public  string? EMail  { get; set; }
		public  string ? ContactPerson { get; set; }

		public List <Books>? Books { get; set; }
		
	}