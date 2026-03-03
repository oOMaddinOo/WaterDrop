using Microsoft.EntityFrameworkCore;
using WaterDrop.Components.Models;
namespace WaterDrop.Components.Data
{
	public class ApplicationDbContext : DbContext
	{

		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}

	
		public DbSet<KloModel> KloModel { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);		
		}
	}
}
