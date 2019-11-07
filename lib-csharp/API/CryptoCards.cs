﻿using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace UtopiaLib
{
	public partial class Client {
		public JArray getCards() {
			return getCards(null);
		}
		
		public JArray getCards(QueryFilter filter = null) {
			JObject params_obj = new JObject();
			return apiQuery("getCards", params_obj, filter)["result"] as JArray;
		}
		
		public string addCard(
			string name    = "my card",
            string color   = "#FFFFFF",
            string numbers = "0000"
        ) {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("name", name) );
			params_obj.Add( new JProperty("color", color) );
			params_obj.Add( new JProperty("preorderNumberInCard", numbers) );
			return apiQuery("addCard", params_obj)["result"].ToString();
		}
		
		public string addCard() {
			return addCard("my card", "#FFFFFF", "0000");
		}
		
		public string addCard(string name = "my card") {
			return addCard(name, "#FFFFFF", "0000");
		}
		
		public string addCard(string name = "my card", string color = "#FFFFFF") {
			return addCard(name, color, "0000");
		}
		
		public bool deleteCard(string cardId = "") {
			JObject params_obj = new JObject();
			params_obj.Add( new JProperty("cardId", cardId) );
			return (bool) apiQuery("deleteCard", params_obj)["result"];
		}
	}
}