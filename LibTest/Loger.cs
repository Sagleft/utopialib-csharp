using System;
using System.Windows.Forms;

namespace LibTest
{
	public class Loger
	{
		public Loger(TextBox new_textBox) {
			this.textbox = new_textBox;
		}
		
		public TextBox textbox = null;
		
		public void print(string info = "") {
			if(this.textbox != null) {
				this.textbox.AppendText(" > " + info + Environment.NewLine);
			}
		}
	}
}
