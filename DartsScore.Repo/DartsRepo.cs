using Darts.Data;
using DartsAPI.Darts.Services;
using System.Linq;

namespace Darts.Repo
{

	public class DartsRepo : IDartsScore
	{
		private readonly DartsScoreDbContext _db;

		public DartsRepo(DartsScoreDbContext db)
		{
			_db = db;
		}
	    IQueryable<DartsScore> IDartsScore.GetDartsScores => _db.DartScore;

	
		public DartsScore GetDartsScore(int? id)
		{
			DartsScore dartsScore = _db.DartScore.Find(id);
			return dartsScore;
		}

		public void Save(DartsScore score)
		{
			if (score.ID == 0)
			{

				_db.DartScore.Add(score);
				_db.SaveChanges();

			}
			else if (score.ID != 0)
			{
				DartsScore dscore = _db.DartScore.Find(score.ID);
				dscore.Score = score.Score;
				dscore.Multiplier = score.Multiplier;
				dscore.Indicator = score.Indicator;
				dscore.DartNo = score.DartNo;

				_db.SaveChanges();
			}


		}
	}
}
