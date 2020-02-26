using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace UtopiaLib
{
	public partial class Client {
		public JArray getVouchers() {
			return apiQuery("getVouchers")["result"] as JArray;
		}
		
		public string createVoucher(decimal amount = 1) {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("amount", amount.ToString().Replace(',', '.')) );
			return apiQuery("createVoucher", params_obj)["result"].ToString();
		}
		
		public string useVoucher(string voucherid = "") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("voucherid", voucherid) );
			return apiQuery("useVoucher", params_obj)["result"].ToString();
		}
		
		public string deleteVoucher(string voucherid = "") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("voucherid", voucherid) );
			return apiQuery("deleteVoucher", params_obj)["result"].ToString();
		}
	}
}
