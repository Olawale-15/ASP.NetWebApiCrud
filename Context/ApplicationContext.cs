using Microsoft.EntityFrameworkCore;
using TestingEfCoreOne.Model;

namespace TestingEfCoreOne.Context
{
	public class ApplicationContext:DbContext
	{
		public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) {

		}

		public DbSet<Author> Author { get; set; }
		
	}
}
