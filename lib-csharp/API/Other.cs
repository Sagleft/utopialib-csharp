﻿using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace UtopiaLib
{
	public partial class Client {
		public bool storageWipe() {
			return (bool) apiQuery("storageWipe")["result"];
		}
		
		public void clearTrayNotifications() {
			apiQuery("clearTrayNotifications");
		}
		
		public bool lowTrafficMode() {
			return (bool) apiQuery("lowTrafficMode")["result"];
		}
		
		public bool setLowTrafficMode(bool enabled = true) {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("enabled", enabled) );
			return (bool) apiQuery("setLowTrafficMode", params_obj)["result"];
		}
		
		public JArray getWhoIsInfo(string owner = "") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("owner", owner) );
			return apiQuery("getWhoIsInfo", params_obj)["result"] as JArray;
		}
		
		public bool requestTreasuryInterestRates() {
			return (bool) apiQuery("requestTreasuryInterestRates")["result"];
		}
		
		public JArray getTreasuryInterestRates() {
			return getTreasuryInterestRates(null);
		}
		
		public JArray getTreasuryInterestRates(QueryFilter filter) {
			return apiQuery("getTreasuryInterestRates")["result"] as JArray;
		}
		
		public bool requestTreasuryTransactionVolumes() {
			return (bool) apiQuery("requestTreasuryTransactionVolumes")["result"];
		}
		
		public JArray getTreasuryTransactionVolumes() {
			return getTreasuryTransactionVolumes(null);
		}
		
		public JArray getTreasuryTransactionVolumes(QueryFilter filter) {
			return apiQuery("getTreasuryTransactionVolumes")["result"] as JArray;
		}
		
		public bool checkClientConnection() {
			JObject result = apiQuery("getSystemInfo") as JObject;
			return result.ContainsKey("result");
		}
		
		public JArray getReleaseNotes() {
			return apiQuery("getReleaseNotes")["result"] as JArray;
		}

		public JArray getSettingInfo(string settingId = "") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("settingId", settingId) );
			return apiQuery("getSettingInfo", params_obj)["result"] as JArray;
		}
		
		public bool setSettingInfo(string settingId = "", string newValue = "") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("settingId", settingId) );
			params_obj.Add( new JProperty("newValue", newValue) );
			return (bool) apiQuery("setSettingInfo", params_obj)["result"];
		}
	}
}
