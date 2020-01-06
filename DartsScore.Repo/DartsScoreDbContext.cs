using Microsoft.EntityFrameworkCore;
using System;
using Darts.Data;

namespace Darts.Repo
{
	 public class DartsScoreDbContext:DbContext
	{
		public DartsScoreDbContext(DbContextOptions<DartsScoreDbContext> options) : base(options) { }
		
		public DbSet<DartsScore> DartScore { get; set; }
		public DbSet<DartSession> DartSession { get; set; }


	}
}
