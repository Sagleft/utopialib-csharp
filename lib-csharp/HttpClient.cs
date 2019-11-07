using System;
using System.Collections.Generic;
using System.Net;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace UtopiaLib
{
	/// <summary>
	/// Description of HttpClient.
	/// </summary>
	public class HttpClient
	{
		public static string buildJsonQuery(string url, string method = "GET", string body = "") {
			//string nonce = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString();
			//string nonce = (DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond).ToString();
			
			//byte[] key = Convert.FromBase64String(secret);
			//byte[] message = Encoding.UTF8.GetBytes(path + nonce);
			//HMACSHA512 hmac = new HMACSHA512(key);
			//string signature = Convert.ToBase64String(hmac.ComputeHash(message));
			
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
			WebRequest request = WebRequest.Create(url);
			request.Method = method;
			//request.Accept = "application/json";
			request.ContentType = "application/json";
			
			if(body != "") {
				byte[] requestBody = Encoding.UTF8.GetBytes(body);
				request.ContentLength = requestBody.Length;
				using (Stream stream = request.GetRequestStream()) {
					stream.Write(requestBody, 0, requestBody.Length);
				}
			}
			
			HttpWebResponse response;
			try {
			    response = (HttpWebResponse)request.GetResponse();
			} catch (WebException exception) {
			    response = (HttpWebResponse)exception.Response;
			}
			
			string responseBody = "";
			using (Stream stream = response.GetResponseStream()) {
				using (StreamReader streamReader = new StreamReader(stream)) {
					responseBody = streamReader.ReadToEnd();
				}
			}
			return responseBody;
		}
	}
}
