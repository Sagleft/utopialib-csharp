using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace UtopiaLib
{
	public partial class Client {
		public string getChannelAvatar(int channelid = 0, string coder = "BASE64", string format = "PNG") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("channelid", channelid.ToString()) );
			params_obj.Add( new JProperty("coder", coder) );
			params_obj.Add( new JProperty("format", format) );
			return (string) apiQuery("getChannelAvatar", params_obj)["result"];
		}
		
		public JArray getChannels(string channel_type = "", string search_filter = "", QueryFilter filter = null) {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("channel_type", channel_type) );
			params_obj.Add( new JProperty("filter", search_filter) );
			return apiQuery("getChannels", params_obj, filter)["result"] as JArray;
		}
		
		public JArray getChannels(string channel_type = "", string search_filter = "") {
			return getChannels(channel_type, search_filter, null);
		}
		
		public JArray getChannels(string channel_type = "") {
			return getChannels(channel_type, "", null);
		}
		
		public string sendChannelMessage(string channelid = "", string message = "my message") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("channelid", channelid) );
			params_obj.Add( new JProperty("message", message) );
			return apiQuery("sendChannelMessage", params_obj)["result"].ToString();
		}
		
		public string sendChannelPicture(string channelid = "", string base64_image = "", string filename_image = "") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("channelid", channelid) );
			if(base64_image != "") {
				params_obj.Add( new JProperty("base64_image", base64_image) );
			}
			if(filename_image != "") {
				params_obj.Add( new JProperty("filename_image", filename_image) );
			}
			return apiQuery("sendChannelPicture", params_obj)["result"].ToString();
		}
		
		public string sendChannelPictureFromBase64(string channelid = "", string base64_image = "") {
			return sendChannelPicture(channelid, base64_image, "");
		}
		
		public string sendChannelPictureFromFile(string channelid = "", string filename_image = "") {
			return sendChannelPicture(channelid, "", filename_image);
		}
		
		public bool joinChannel(string channelid = "", string password = "") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("ident", channelid) );
			params_obj.Add( new JProperty("password", password) );
			return (bool) apiQuery("joinChannel", params_obj)["result"];
		}
		
		public bool leaveChannel(string channelid = "") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("channelid", channelid) );
			return (bool) apiQuery("leaveChannel", params_obj)["result"];
		}
		
		public JArray getChannelMessages(string channelid = "") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("channelid", channelid) );
			return apiQuery("getChannelMessages", params_obj)["result"] as JArray;
		}
		
		public JArray getChannelInfo(string channelid = "") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("channelid", channelid) );
			return apiQuery("getChannelInfo", params_obj)["result"] as JArray;
		}
		
		public JArray getChannelModerators(string channelid = "") {
			return getChannelModerators(channelid, null);
		}
		
		public JArray getChannelModerators(string channelid = "", QueryFilter filter = null) {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("channelid", channelid) );
			return apiQuery("getChannelModerators", params_obj, filter)["result"] as JArray;
		}
		
		public JArray getChannelContacts(string channelid = "") {
			return getChannelContacts(channelid, null);
		}
		
		public JArray getChannelContacts(string channelid = "", QueryFilter filter = null) {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("channelid", channelid) );
			return apiQuery("getChannelContacts", params_obj, filter)["result"] as JArray;
		}
		
		public string getChannelModeratorRight(string channelid = "", string moderator = "") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("channelid", channelid) );
			params_obj.Add( new JProperty("moderator", moderator) );
			return apiQuery("getChannelModeratorRight", params_obj)["result"].ToString();
		}
		
		public string createChannel(
			string channel_name        = "my channel",
			string description         = "",
			string read_only           = "",
			string read_only_privacy   = "",
			string password            = "",
			string languages           = "",
			string hashtags            = "",
			string geoTag              = "",
			string base64_avatar_image = "",
			string hide_in_UI          = ""
		) {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("channel_name", channel_name) );
			params_obj.Add( new JProperty("description", description) );
			params_obj.Add( new JProperty("read_only", read_only) );
			params_obj.Add( new JProperty("read_only_privacy", read_only_privacy) );
			params_obj.Add( new JProperty("password", password) );
			params_obj.Add( new JProperty("languages", languages) );
			params_obj.Add( new JProperty("hashtags", hashtags) );
			params_obj.Add( new JProperty("geoTag", geoTag) );
			params_obj.Add( new JProperty("base64_avatar_image", base64_avatar_image) );
			params_obj.Add( new JProperty("hide_in_UI", hide_in_UI) );
			return apiQuery("createChannel", params_obj)["result"].ToString();
		}
		
		public string modifyChannel(
			string channelid = "",
			string description = "",
			string read_only = "",
			string read_only_privacy = "",
			string languages = "",
			string hashtags = "",
			string geoTag = "",
			string base64_avatar_image = "",
			string hide_in_UI = ""
		) {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("channelid", channelid) );
			params_obj.Add( new JProperty("description", description) );
			params_obj.Add( new JProperty("read_only", read_only) );
			params_obj.Add( new JProperty("read_only_privacy", read_only_privacy) );
			params_obj.Add( new JProperty("languages", languages) );
			params_obj.Add( new JProperty("hashtags", hashtags) );
			params_obj.Add( new JProperty("geoTag", geoTag) );
			params_obj.Add( new JProperty("base64_avatar_image", base64_avatar_image) );
			params_obj.Add( new JProperty("hide_in_UI", hide_in_UI) );
			return apiQuery("modifyChannel", params_obj)["result"].ToString();
		}
		
		public bool deleteChannel(string channelid = "") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("channelid", channelid) );
			return (bool) apiQuery("deleteChannel", params_obj)["result"];
		}
		
		public JObject getChannelSystemInfo(string channelid = "") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("channelid", channelid) );
			return apiQuery("getChannelSystemInfo", params_obj)["result"] as JObject;
		}
	}
}
