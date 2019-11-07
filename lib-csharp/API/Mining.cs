using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace UtopiaLib
{
	public partial class Client {
		public bool enableMining(bool enabled = true) {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("enabled", enabled.ToString()) );
			return (bool) apiQuery("enableMining", params_obj)["result"];
		}
		
		public bool enableMining() {
			return enableMining(true);
		}
		
		public bool disableMining() {
			return enableMining(false);
		}
		
		public bool enableInterest(bool enabled = true) {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("enabled", enabled.ToString()) );
			return (bool) apiQuery("addCard", params_obj)["result"];
		}
		
		public bool enableInterest() {
			return enableInterest(true);
		}
		
		public bool disableInterest() {
			return enableInterest(false);
		}
		
		public bool enableHistoryMining(bool enabled = true) {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("enabled", enabled.ToString()) );
			return (bool) apiQuery("enableHistoryMining", params_obj)["result"];
		}
		
		public bool enableHistoryMining() {
			return enableHistoryMining(true);
		}
		
		public bool disableHistoryMining() {
			return enableHistoryMining(false);
		}
		
		public int statusHistoryMining() {
			string result = apiQuery("statusHistoryMining")["result"].ToString();
			return Helpers.parseInt(result);
		}
		
		public JArray getMiningBlocks() {
			return getMiningBlocks(null);
		}
		
		public JArray getMiningBlocks(QueryFilter filter = null) {
			JObject params_obj = new JObject();
			return apiQuery("getMiningBlocks", params_obj, filter)["result"] as JArray;
		}
		
		public JObject getMiningInfo() {
			return apiQuery("getMiningInfo")["result"] as JObject;
		}
	}
}
