using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace UtopiaLib
{
	public partial class Client {
		public JArray getTransfersFromManager() {
			return apiQuery("getTransfersFromManager")["result"] as JArray;
		}

		public JArray getFilesFromManager(QueryFilter filter = null) {
			return apiQuery("getFilesFromManager", null, filter)["result"] as JArray;
		}

		public bool abortTransfers(int transfer_id = 0) {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("transferId", transfer_id) );
			return (bool) apiQuery("abortTransfers", params_obj)["result"];
		}

		public bool hideTransfers(int transfer_id = 0) {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("transferId", transfer_id) );
			return (bool) apiQuery("hideTransfers", params_obj)["result"];
		}

		public string getFile(int file_id = 0) {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("fileId", file_id) );
			JObject result = apiQuery("getFile", params_obj)["result"] as JObject;
			if(!result.ContainsKey("body")) {
				return "";
			} else {
				return result["body"].ToString();
			}
		}

		public bool deleteFile(int file_id = 0) {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("fileId", file_id) );
			return (bool) apiQuery("deleteFile", params_obj)["result"];
		}

		public bool sendFileByMessage(string pubkey = "", int file_id = 55779) {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("to", pubkey) );
			params_obj.Add( new JProperty("fileId", file_id) );
			return (bool) apiQuery("sendFileByMessage", params_obj)["result"];
		}
		
		public int uploadFile(string base64 = "", string filename = "file.ext") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("fileDataBase64", base64) );
			params_obj.Add( new JProperty("fileName", filename) );
			return (int) apiQuery("uploadFile", params_obj)["result"];
		}
	}
}
