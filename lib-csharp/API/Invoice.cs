using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace UtopiaLib
{
	public partial class Client {
		public JArray getInvoices(
			string cardId          = "",
		    string invoiceId       = "",
		    string pk              = "",
		    string transactionId   = "",
		    string status          = "",
		    string startDateTime   = "",
		    string endDateTime     = "",
		    string referenceNumber = "",
		    QueryFilter filter     = null
		) {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("cardId", cardId) );
			params_obj.Add( new JProperty("invoiceId", invoiceId) );
			params_obj.Add( new JProperty("pk", pk) );
			params_obj.Add( new JProperty("transactionId", transactionId) );
			params_obj.Add( new JProperty("status", status) );
			params_obj.Add( new JProperty("startDateTime", startDateTime) );
			params_obj.Add( new JProperty("endDateTime", endDateTime) );
			params_obj.Add( new JProperty("referenceNumber", referenceNumber) );
			return apiQuery("getInvoices", params_obj, filter)["result"] as JArray;
		}
		
		public string getInvoiceByReferenceNumber(string referenceNumber = "") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("referenceNumber", referenceNumber) );
			return apiQuery("getInvoiceByReferenceNumber", params_obj)["result"].ToString();
		}
		
		public string getTransactionIdByReferenceNumber(string referenceNumber = "") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("referenceNumber", referenceNumber) );
			return apiQuery("getTransactionIdByReferenceNumber", params_obj)["result"].ToString();
		}
		
		public string sendInvoice(string cardid = "", decimal amount = 1, string comment = "") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("cardid", cardid) );
			params_obj.Add( new JProperty("amount", amount.ToString()) );
			params_obj.Add( new JProperty("comment", comment) );
			return apiQuery("sendInvoice", params_obj)["result"].ToString();
		}
		
		public string acceptInvoice(string invoiceid = "") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("invoiceid", invoiceid) );
			return apiQuery("acceptInvoice", params_obj)["result"].ToString();
		}
		
		public string declineInvoice(string invoiceid = "") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("invoiceid", invoiceid) );
			return apiQuery("declineInvoice", params_obj)["result"].ToString();
		}
		
		public string cancelInvoice(string invoiceid = "") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("invoiceid", invoiceid) );
			return apiQuery("cancelInvoice", params_obj)["result"].ToString();
		}
	}
}
