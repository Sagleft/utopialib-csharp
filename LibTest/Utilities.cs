using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LibTest
{
	public class Utilities
	{
		public static string JsonPrettify(string json)
	    {
			return JToken.Parse(json).ToString(Formatting.Indented);
	    }
	}
}
