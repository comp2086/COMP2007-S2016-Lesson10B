namespace COMP2007_S2016_Lesson10B.Models
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class MusicStoreContext : DbContext
	{
		public MusicStoreContext()
			: base("name=MusicStoreConnection")
		{
		}
		
		public  DbSet<Album> Albums { get; set; }
		public DbSet<Genre> Genres { get; set; }
		public DbSet<Artist> Artists { get; set; }
	}
}
