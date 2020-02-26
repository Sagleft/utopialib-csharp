using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace UtopiaLib
{
	public partial class Client {
		public JObject getSystemInfo() {
			return apiQuery("getSystemInfo")["result"] as JObject;
		}
		
		public bool isNetworkEnabled() {
			return (bool) getSystemInfo()["networkEnabled"];
		}
		
		public JObject getNetworkConnections() {
			return getNetworkConnections(null);
		}
		
		public JObject getNetworkConnections(QueryFilter filter) {
			return apiQuery("getNetworkConnections", new JObject(), filter)["result"] as JObject;
		}
	}
}
