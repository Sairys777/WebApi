using Microsoft.EntityFrameworkCore;
using WebApi.DataAccessLayer.Entities;

namespace WebApi.DataAccessLayer
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{
		}

		public DbSet<Post> Posts { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.ApplyConfiguration(new TestEntityConfiguration());
		}
	}
}