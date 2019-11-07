using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UtopiaLib;

namespace LibTest
{
	public partial class MainForm : Form
	{
		UtopiaLib.Client client;
		Loger loger;
		
		public MainForm()
		{
			InitializeComponent();
			this.loger = new Loger(textBox_log);
		}
		
		void response2log(object response) {
			string result = "";
			try {
				result = JsonConvert.SerializeObject(response, Formatting.Indented);
			} catch (Exception ex) {
				result = "Catched Exception: " + ex.Message;
			}
			loger.print(result);
		}
		
		void Btn_connectClick(object sender, EventArgs e)
		{
			loger.print("Trying to connect to the client ..");
			int port = 22648;
			int.TryParse(textBox_port.Text, out port);
			client = new UtopiaLib.Client(textBox2_host.Text, port, textBox_token.Text);
			
			string result = "";
			try {
				result = JsonConvert.SerializeObject(client.getSystemInfo(), Formatting.Indented);
			} catch (UtopiaLib.ApiErrorException ex) {
				result = "Catched ApiErrorException: " + ex.Message;
			}
			
			loger.print(result);
		}
		
		void Btn_getSystemInfoClick(object sender, EventArgs e)
		{
			response2log(client.getSystemInfo());
		}
		
		void Btn_clearlogClick(object sender, EventArgs e)
		{
			textBox_log.Clear();
		}
	}
}
