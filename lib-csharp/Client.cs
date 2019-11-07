using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace UtopiaLib
{
	public class QueryFilter {
		public string sortBy = "";
		public string offset = "";
		public string limit  = "";
	}
	
	public partial class Client
	{
		public string host;
		public int port;
		public string token;
		//public ICredentials credentials;
		
		public Client(
			string connection_host = "127.0.0.1",
			int connection_port = 22824,
			string connection_token = ""
		) {
			this.host  = connection_host;
			this.port  = connection_port;
			this.token = connection_token;
		}
		
		string getApiUrl() {
			return this.host + ":" + this.port.ToString() + "/api/1.0/";
		}
		
		/// <summary>
		/// Makes an arbitrary api request
		/// </summary>
		/// <param name="method">api method</param>
		/// <param name="params_obj">data</param>
		/// <param name="filter">QueryFilter object</param>
		/// <exception cref="ApiErrorException">information about the error that the client returned when the api failed</exception>
		/// <returns>JObject</returns>
		public JObject apiQuery(string method = "getSystemInfo", JObject params_obj = null, QueryFilter filter = null) {
			JObject json_obj = new JObject();
			if(params_obj == null) {
				params_obj = new JObject();
			}
			
			json_obj.Add( new JProperty("method", method) );
			json_obj.Add( new JProperty("params", params_obj) );
			json_obj.Add( new JProperty("token", this.token) );
			if(filter != null) {
				json_obj.Add( new JProperty("filter", filter) );
			}
			
			string jsonQuery = json_obj.ToString();
			
			//http(s)://127.0.0.1:port/api/1.0
			string result = HttpClient.buildJsonQuery(getApiUrl(), "POST", jsonQuery);
			JObject result_obj = JsonConvert.DeserializeObject<JObject>(result);
			//ApiErrorException
			if(result_obj.ContainsKey("error")) {
				throw new ApiErrorException(result_obj["error"].ToString());
			}
			return result_obj;
		}
	}
}