using Microsoft.EntityFrameworkCore;

namespace CharacterSheetApp.Models
{
	public class ApplicationDbContext : DbContext
	{
		public DbSet<Character> Characters { get; set; }
	}
}