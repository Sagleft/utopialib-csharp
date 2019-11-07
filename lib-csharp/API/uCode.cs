using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace UtopiaLib
{
	public partial class Client {
		public string ucodeEncode(string hex_code = "", int size_image = 128, string coder = "BASE64", string format = "JPG") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("hex_code", hex_code) );
			params_obj.Add( new JProperty("size_image", size_image) );
			params_obj.Add( new JProperty("coder", coder) );
			params_obj.Add( new JProperty("format", format) );
			return apiQuery("ucodeEncode", params_obj)["result"].ToString();
		}
		
		public string ucodeDecode(string base64_image = "") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("base64_image", base64_image) );
			return apiQuery("ucodeDecode", params_obj)["result"].ToString();
		}
		
		public int getWebSocketState() {
			string result = apiQuery("getWebSocketState")["result"].ToString();
			return Helpers.parseInt(result);
		}
		
		public int setWebSocketState(bool enabled = true, int port = 22827) {
			string result = apiQuery("setWebSocketState")["result"].ToString();
			return Helpers.parseInt(result);
		}
	}
}
