using Darts.Data;
using DartsAPI.Darts.Services;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DartsAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ScoreController : ControllerBase
	{

		private readonly IDartsScore dartsScore;


		public ScoreController(IDartsScore _db)
		{
			dartsScore = _db;
		}

		[HttpPost]
		public IActionResult Save([FromBody] DartsScore data)
		{
			if (data == null)
			{ return BadRequest(); }
			dartsScore.Save(data);
			return Ok(data);
		}

		[HttpGet]
		public IActionResult GetScore()
		{
			IQueryable<DartsScore> data = dartsScore.GetDartsScores;
			return Ok(data);
		}
	}
}