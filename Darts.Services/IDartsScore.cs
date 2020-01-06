using Darts.Data;
using System;
using System.Linq;

namespace DartsAPI.Darts.Services
{
	public interface IDartsScore
	{
		DartsScore GetDartsScore(int? id);
		IQueryable<DartsScore> GetDartsScores { get; }
		void Save(DartsScore score);

	} 
}
