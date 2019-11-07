using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace UtopiaLib
{
	public partial class Client {
		public decimal getBalance() {
			string result = apiQuery("getBalance")["result"].ToString();
			return Helpers.parseDecimal(result);
		}
	}
}
