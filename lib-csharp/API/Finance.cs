using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace UtopiaLib
{
	public partial class Client {
		public JObject getFinanceSystemInformation() {
			return apiQuery("getFinanceSystemInformation")["result"] as JObject;
		}
		
		public JArray getFinanceHistory(string query_filters = "ALL_TRANSFERS", QueryFilter filter = null, string referenceNumber = "", string toDate = "", string fromDate = "", string batchId = "", string fromAmount = "", string toAmount = "") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("filters", query_filters) );
			params_obj.Add( new JProperty("referenceNumber", referenceNumber) );
			params_obj.Add( new JProperty("toDate", toDate) );
			params_obj.Add( new JProperty("fromDate", fromDate) );
			params_obj.Add( new JProperty("batchId", batchId) );
			params_obj.Add( new JProperty("fromAmount", fromAmount) );
			params_obj.Add( new JProperty("toAmount", toAmount) );
			return apiQuery("getFinanceHistory", params_obj, filter)["result"] as JArray;
		}
	}
}
