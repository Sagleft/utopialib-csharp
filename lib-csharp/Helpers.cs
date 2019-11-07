using System;

namespace UtopiaLib
{
	public class Helpers
	{
		public static int parseInt(string unparsed) {
			int id = 0;
			int.TryParse(unparsed, out id);
			return id;
		}
		
		public static decimal parseDecimal(string unparsed) {
			decimal id = 0;
			decimal.TryParse(unparsed, out id);
			return id;
		}
	}
}
