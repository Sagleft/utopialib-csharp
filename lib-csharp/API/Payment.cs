using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace UtopiaLib
{
	public partial class Client {
		public string sendPayment(string to = "", string cardid = "", decimal amount = 1, string comment = "", string fromCard = "") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("to", to) );
			params_obj.Add( new JProperty("cardid", cardid) );
			params_obj.Add( new JProperty("amount", amount.ToString()) );
			params_obj.Add( new JProperty("comment", comment) );
			params_obj.Add( new JProperty("fromCard", fromCard) );
			return apiQuery("sendPayment", params_obj)["result"].ToString();
		}
	}
}
