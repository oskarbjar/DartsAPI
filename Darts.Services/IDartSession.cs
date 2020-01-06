using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Darts.Data;

namespace DartsAPI.Darts.Services
{
	public interface IDartSession
	{
		//DartSession GetDartSession(int? id);
		IQueryable<DartSession> GetDartSessions { get; }
		void Save(DartSession session);

	}
}
