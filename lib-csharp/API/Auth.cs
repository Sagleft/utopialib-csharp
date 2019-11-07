using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace UtopiaLib
{
	public partial class Client {
		public bool sendAuthorizationRequest(string pk = "", string message = "auqth request") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("pk", pk) );
			params_obj.Add( new JProperty("message", message) );
			return (bool) apiQuery("sendAuthorizationRequest", params_obj)["result"];
		}
		
		public bool acceptAuthorizationRequest(string pk = "", string message = "auth request accepted") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("pk", pk) );
			params_obj.Add( new JProperty("message", message) );
			return (bool) apiQuery("acceptAuthorizationRequest", params_obj)["result"];
		}
		
		public bool rejectAuthorizationRequest(string pk = "", string message = "auth request rejected") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("pk", pk) );
			params_obj.Add( new JProperty("message", message) );
			return (bool) apiQuery("rejectAuthorizationRequest", params_obj)["result"];
		}
	}
}
