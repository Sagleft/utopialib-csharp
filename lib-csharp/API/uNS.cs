using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace UtopiaLib
{
	public partial class Client {
		public string requestUnsTransfer(string name = "", string hexNewOwnerPk = "") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("name", name) );
			params_obj.Add( new JProperty("hexNewOwnerPk", hexNewOwnerPk) );
			return apiQuery("requestUnsTransfer", params_obj)["result"].ToString();
		}
		
		public string acceptUnsTransfer(string requestId = "") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("requestId", requestId) );
			return apiQuery("acceptUnsTransfer", params_obj)["result"].ToString();
		}
		
		public string declineUnsTransfer(string requestId = "") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("requestId", requestId) );
			return apiQuery("declineUnsTransfer", params_obj)["result"].ToString();
		}
		
		public JArray incomingUnsTransfer() {
			return incomingUnsTransfer(null);
		}
		
		public JArray incomingUnsTransfer(QueryFilter filter = null) {
			JObject params_obj = new JObject();
			return apiQuery("incomingUnsTransfer", params_obj, filter)["result"] as JArray;
		}
		
		public JArray outgoingUnsTransfer() {
			return outgoingUnsTransfer(null);
		}
		
		public JArray outgoingUnsTransfer(QueryFilter filter = null) {
			JObject params_obj = new JObject();
			return apiQuery("outgoingUnsTransfer", params_obj, filter)["result"] as JArray;
		}
		
		public string unsCreateRecordRequest(string nick = "", string valid = "", string isPrimary = "", string channelId = "") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("nick", nick) );
			params_obj.Add( new JProperty("valid", valid) );
			params_obj.Add( new JProperty("isPrimary", isPrimary) );
			params_obj.Add( new JProperty("channelId", channelId) );
			return apiQuery("unsCreateRecordRequest", params_obj)["result"].ToString();
		}
		
		public string unsModifyRecordRequest(string nick = "", string valid = "", string isPrimary = "", string channelId = "") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("nick", nick) );
			params_obj.Add( new JProperty("valid", valid) );
			params_obj.Add( new JProperty("isPrimary", isPrimary) );
			params_obj.Add( new JProperty("channelId", channelId) );
			return apiQuery("unsModifyRecordRequest", params_obj)["result"].ToString();
		}
		
		public string unsDeleteRecordRequest(string nick = "") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("nick", nick) );
			return apiQuery("unsDeleteRecordRequest", params_obj)["result"].ToString();
		}
		
		public JArray unsSearchByPk(string search_filter = "") {
			return unsSearchByPk(search_filter, null);
		}
		
		public JArray unsSearchByPk(string search_filter = "", QueryFilter filter = null) {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("filter", search_filter) );
			return apiQuery("unsSearchByPk", params_obj, filter)["result"] as JArray;
		}
		
		public JArray unsSearchByNick(string search_filter = "") {
			return unsSearchByNick(search_filter, null);
		}
		
		public JArray unsSearchByNick(string search_filter = "", QueryFilter filter = null) {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("filter", search_filter) );
			return apiQuery("unsSearchByNick", params_obj, filter)["result"] as JArray;
		}
		
		public JObject getUnsSyncInfo() {
			return apiQuery("getUnsSyncInfo")["result"] as JObject;
		}
		
		public JArray unsRegisteredNames(QueryFilter filter = null) {
			return apiQuery("unsRegisteredNames", new JObject(), filter)["result"] as JArray;
		}
		
		public JArray unsRegisteredNames() {
			return unsRegisteredNames(null);
		}
		
		public JObject summaryUnsRegisteredNames(string fromDate = "", string toDate = "") {
			return summaryUnsRegisteredNames(fromDate, toDate, null);
		}
		
		public JObject summaryUnsRegisteredNames(string fromDate = "", string toDate = "", QueryFilter filter = null) {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("fromDate", fromDate) );
			params_obj.Add( new JProperty("toDate", toDate) );
			return apiQuery("summaryUnsRegisteredNames", params_obj, filter)["result"] as JObject;
		}
	}
}
