using Darts.Data;
using DartsAPI.Darts.Services;
using System.Linq;

namespace Darts.Repo
{

	public class DartSessionRepo : IDartSession
	{
		private readonly DartsScoreDbContext _db;

		public DartSessionRepo(DartsScoreDbContext db)
		{
			_db = db;
		}
	    IQueryable<DartSession> IDartSession.GetDartSessions => _db.DartSession;

	
		//public DartSession GetDartSession(int? id)
		//{
		//	DartSession dartsSession = _db.DartSession.Find(id);
		//	return dartsSession;
		//}

		public void Save(DartSession session)
		{
			if (session.ID == 0)
			{

				_db.DartSession.Add(session);
				_db.SaveChanges();
			}
			//else if (score.ID != 0)
			//{
			//	DartsScore dscore = _db.DartScore.Find(score.ID);
			//	dscore.Score = score.Score;
			//	dscore.Multiplier = score.Multiplier;
			//	dscore.Indicator = score.Indicator;
			//	dscore.DartNo = score.DartNo;

			//	_db.SaveChanges();
			//}


		}
	}
}
