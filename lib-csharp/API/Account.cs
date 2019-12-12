using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace UtopiaLib
{
	public partial class Client {
		public JObject getProfileStatus() {
			return apiQuery("getProfileStatus")["result"] as JObject;
		}
		
		public bool setProfileStatus(string status = "", string mood = "") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("status", status) );
			params_obj.Add( new JProperty("mood", mood) );
			return (bool) apiQuery("setProfileStatus", params_obj)["result"];
		}
	}
}
