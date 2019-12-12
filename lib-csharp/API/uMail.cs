using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace UtopiaLib
{
	public partial class Client {
		public JArray getEmailFolder(string folderType = "", string search_filter = "") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("folderType", folderType) );
			params_obj.Add( new JProperty("filter", search_filter) );
			return apiQuery("getEmailFolder", params_obj)["result"] as JArray;
		}
		
		public JArray getEmailFolder(string folderType = "") {
			return getEmailFolder(folderType, "");
		}
		
		public JArray getEmails(string folderType = "", string search_filter = "", QueryFilter filter = null) {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("folderType", folderType) );
			params_obj.Add( new JProperty("filter", search_filter) );
			return apiQuery("getEmails", params_obj, filter)["result"] as JArray;
		}
		
		public JArray getEmails(string folderType = "", string search_filter = "") {
			return getEmails(folderType, search_filter, null);
		}
		
		public JArray getEmails(string folderType = "") {
			return getEmails(folderType, "", null);
		}
		
		public JObject getEmailById(int id = 33) {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("id", id.ToString()) );
			return apiQuery("getEmailById", params_obj)["result"] as JObject;
		}
		
		public bool deleteEmail(int id = 33) {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("id", id.ToString()) );
			return (bool) apiQuery("deleteEmail", params_obj)["result"];
		}
		
		public bool sendEmailMessage(string to = "", string subject = "uMail subject", string body = "test message") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("to", new string[] {to} ) );
			params_obj.Add( new JProperty("subject", subject) );
			params_obj.Add( new JProperty("body", body) );
			return (bool) apiQuery("sendEmailMessage", params_obj)["result"];
		}
		
		public bool sendEmailMessages(string[] to, string subject = "uMail subject", string body = "test message") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("to", to) );
			params_obj.Add( new JProperty("subject", subject) );
			params_obj.Add( new JProperty("body", body) );
			return (bool) apiQuery("sendEmailMessage", params_obj)["result"];
		}
		
		public bool sendReplyEmailMessage(int id = 33, string body = "test message", string subject = "test") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("id", id.ToString()) );
			params_obj.Add( new JProperty("body", body) );
			params_obj.Add( new JProperty("subject", subject) );
			return (bool) apiQuery("sendReplyEmailMessage", params_obj)["result"];
		}
		
		public bool sendForwardEmailMessage(int id = 33, string to = "", string body = "test message", string subject = "test") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("id", id.ToString()) );
			params_obj.Add( new JProperty("to", to) );
			params_obj.Add( new JProperty("body", body) );
			params_obj.Add( new JProperty("subject", subject) );
			return (bool) apiQuery("sendForwardEmailMessage", params_obj)["result"];
		}
	}
}
