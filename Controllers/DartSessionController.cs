using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DartsAPI.Darts.Services;
using Darts.Data;

namespace DartsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DartSessionController : ControllerBase
    {
		private readonly IDartSession dartSession;

		public DartSessionController(IDartSession _db)
		{
			dartSession = _db;
		}

		[HttpPost]
		public IActionResult Save([FromBody] DartSession data)
		{
			if (data == null)
			{ return BadRequest(); }

			var ds = new DartSession
			{
				SessionDate = data.SessionDate
			};
			dartSession.Save(ds);
			
			return Ok(ds);
		}
		[HttpGet]
		public IActionResult GetDartSessions()
		{
			IQueryable<DartSession> data = dartSession.GetDartSessions;
			return Ok(data);
		}
		//[HttpGet]
		//public IActionResult GetDartSession(int ID)
		//{
		//	IQueryable<DartSession> data = dartSession.GetDartSessions.Where(x=>x.ID == ID);
		//	return Ok(data);
		//}


	}
}