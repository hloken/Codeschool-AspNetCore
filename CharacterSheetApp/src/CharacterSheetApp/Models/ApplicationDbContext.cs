using Microsoft.EntityFrameworkCore;

namespace CharacterSheetApp.Models
{
	public class ApplicationDbContext : DbContext
	{
	    public ApplicationDbContext(DbContextOptions options) : base(options)
	    {
	    }

	    public DbSet<Character> Characters { get; set; }
        public DbSet<Quest> Quests { get; set; }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
	    {
	        modelBuilder.Entity<Character>().ToTable("Character");
	        modelBuilder.Entity<Quest>().ToTable("Quest");
	    }
	}
}