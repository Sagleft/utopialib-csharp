using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace UtopiaLib
{
	public partial class Client {
		public int sendInstantSticker(string to = "", string collection = "434", string name = "343") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("to", to) );
			params_obj.Add( new JProperty("text", collection) );
			params_obj.Add( new JProperty("text", name) );
			string result = apiQuery("sendInstantMessage", params_obj)["result"].ToString();
			return Helpers.parseInt(result);
		}
		
		public JArray getStickerCollections(string to = "", string collection = "434", string name = "343") {
			return apiQuery("getStickerCollections")["result"] as JArray;
		}
		
		public JArray getStickerNamesByCollection(string collection_name = "Default Stickers") {
			return apiQuery("getStickerNamesByCollection")["result"] as JArray;
		}
		
		public string getImageSticker(string collection_name = "Default Stickers", string sticker_name = "airship", string coder = "BASE64") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("collection_name", collection_name) );
			params_obj.Add( new JProperty("sticker_name", sticker_name) );
			params_obj.Add( new JProperty("coder", coder) );
			return apiQuery("getImageSticker", params_obj)["result"].ToString();
		}
	}
}
