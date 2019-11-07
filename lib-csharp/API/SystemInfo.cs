using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace UtopiaLib
{
	public partial class Client {
		public JObject getSystemInfo() {
			return apiQuery("getSystemInfo")["result"] as JObject;
		}
		
		public JArray getNetworkConnections() {
			return getNetworkConnections(null);
		}
		
		public JArray getNetworkConnections(QueryFilter filter) {
			return apiQuery("getNetworkConnections", new JObject(), filter)["result"] as JArray;
		}
	}
}
