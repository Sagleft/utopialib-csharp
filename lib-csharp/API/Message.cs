using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace UtopiaLib
{
	public partial class Client {
		public int sendInstantMessage(string to = "", string text = "Test") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("to", to) );
			params_obj.Add( new JProperty("text", text) );
			string result = (string) apiQuery("sendInstantMessage", params_obj)["result"];
			return Helpers.parseInt(result);
		}
		
		public int sendInstantQuote(string to = "", string text = "test", int id_message = 123) {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("to", to) );
			params_obj.Add( new JProperty("text", text) );
			params_obj.Add( new JProperty("text", id_message.ToString()) );
			string result = (string) apiQuery("sendInstantMessage", params_obj)["result"];
			return Helpers.parseInt(result);
		}
		
		public int sendInstantBuzz(string to = "", string comments = "test") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("to", to) );
			params_obj.Add( new JProperty("comments", comments) );
			string result = apiQuery("sendInstantBuzz", params_obj)["result"].ToString();
			return Helpers.parseInt(result);
		}
		
		public int sendInstantInvitation(string to = "", string channelid = "", string description = "", string comments = "") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("to", to) );
			params_obj.Add( new JProperty("channelid", channelid) );
			params_obj.Add( new JProperty("description", description) );
			params_obj.Add( new JProperty("comments", comments) );
			string result = apiQuery("sendInstantInvitation", params_obj)["result"].ToString();
			return Helpers.parseInt(result);
		}
		
		public bool removeInstantMessages(string pk = "") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("hex_contact_public_key", pk) );
			return (bool) apiQuery("removeInstantMessages", params_obj)["result"];
		}
		
		public JArray getContactMessages(string pk = "") {
			return getContactMessages(pk, null);
		}
		
		public JArray getContactMessages(string pk = "", QueryFilter filter = null) {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("pk", pk) );
			return apiQuery("getContactMessages", params_obj, filter)["result"] as JArray;
		}
		
		public int pinInstantMessage(string to = "", int messageId = 0, bool pin = true) {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("to", to) );
			params_obj.Add( new JProperty("messageId", messageId) );
			params_obj.Add( new JProperty("pin", pin) );
			
			string result = apiQuery("pinInstantMessage", params_obj)["result"].ToString();
			return Helpers.parseInt(result);
		}
		
		public JArray getPinnedMessages(string to = "") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("to", to) );
			return apiQuery("getPinnedMessages", params_obj)["result"] as JArray;
		}
		
		public int bookmarkInstantMessage(int messageId = 0, string comments = "") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("messageId", messageId) );
			params_obj.Add( new JProperty("comments", comments) );
			
			string result = apiQuery("bookmarkInstantMessage", params_obj)["result"].ToString();
			return Helpers.parseInt(result);
		}
	}
}
