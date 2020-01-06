using System;

namespace Darts.Data
{
	public class DartsScore
	{
		public int ID { get; set; }
		public int Score { get; set; }
		public string Indicator { get; set; }
		public int Multiplier { get; set; }
		public int DartNo { get; set; }
		//public DartSession SessionID { get; set; }


	}

	public class DartSession
	{
		public int ID { get; set; }
		public DateTime SessionDate { get; set; }

		public int playerID { get; set; }
	}
}