using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace UtopiaLib
{
	public partial class Client {
		public bool deleteContact(string pk = "") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("pk", pk) );
			return (bool) apiQuery("deleteContact", params_obj)["result"];
		}
	}
}
