using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace UtopiaLib
{
	public partial class Client {
		public JArray getProxyMappings() {
			return getProxyMappings(null);
		}
		
		public JArray getProxyMappings(QueryFilter filter) {
			return apiQuery("getProxyMappings", new JObject(), filter)["result"] as JArray;
		}
		
		public int createProxyMapping(string srcHost = "", int srcPort = 80, string dstHost = "127.0.0.1", int dstPort = 80, bool enabled = true) {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("srcHost", srcHost) );
			params_obj.Add( new JProperty("srcPort", srcPort.ToString()) );
			params_obj.Add( new JProperty("dstHost", dstHost) );
			params_obj.Add( new JProperty("dstPort", dstPort.ToString()) );
			params_obj.Add( new JProperty("enabled", enabled.ToString()) );
			string result = apiQuery("createProxyMapping", params_obj)["result"].ToString();
			return Helpers.parseInt(result);
		}
		
		public bool enableProxyMapping(int mappingId = 15) {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("mappingId", mappingId ) );
			return (bool) apiQuery("enableProxyMapping", params_obj)["result"];
		}
		
		public bool disableProxyMapping(int mappingId = 15) {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("mappingId", mappingId ) );
			return (bool) apiQuery("disableProxyMapping", params_obj)["result"];
		}
		
		public bool removeProxyMapping(int mappingId = 15) {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("mappingId", mappingId ) );
			return (bool) apiQuery("removeProxyMapping", params_obj)["result"];
		}
	}
}
