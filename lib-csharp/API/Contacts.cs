using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace UtopiaLib
{
	public partial class Client {
		public bool deleteContact(string pk = "") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("pk", pk) );
			return (bool) apiQuery("deleteContact", params_obj)["result"];
		}
		
		public JObject getOwnContact() {
			return apiQuery("getOwnContact")["result"] as JObject;
		}
		
		public JArray getContacts() {
			return getContacts("");
		}
		
		public JArray getContacts(string search_filter = "") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("filter", search_filter) );
			return apiQuery("getContacts", params_obj)["result"] as JArray;
		}
		
		public string getContactAvatar(string pk = "", string coder = "BASE64", string format = "PNG") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("pk", pk) );
			params_obj.Add( new JProperty("coder", coder) );
			params_obj.Add( new JProperty("format", format) );
			return apiQuery("getContactAvatar", params_obj)["result"].ToString();
		}
		
		public bool setContactGroup(string pk = "", string groupName = "Test") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("contactPublicKey", pk) );
			params_obj.Add( new JProperty("groupName", groupName) );
			return (bool) apiQuery("setContactGroup", params_obj)["result"];
		}
		
		public bool setContactNick(string pk = "", string newNick = "") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("contactPublicKey", pk) );
			params_obj.Add( new JProperty("newNick", newNick) );
			return (bool) apiQuery("setContactNick", params_obj)["result"];
		}
	}
}
