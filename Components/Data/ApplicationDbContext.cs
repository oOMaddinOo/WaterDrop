using Microsoft.EntityFrameworkCore;
namespace WaterDrop.Components.Data
{
	public class ApplicationDbContext : DbContext
	{

		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}

	
		public DbSet<Models.KloModel> KloModels { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);		
		}
	}
}
