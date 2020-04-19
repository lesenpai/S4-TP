using System;
using System.Windows.Forms;

namespace s4_tp
{
	public partial class ManagerForm : Form
	{
		public ManagerForm()
		{
			InitializeComponent();
		}

		private void ShowFormX_btn_Click(object sender, EventArgs e)
		{
			switch (((Button)sender).Name)
			{
				case "ShowL1_btn":
					new Lab1Form().Show();
					break;
				case "ShowL2_btn":
					new Lab2Form().Show();
					break;
					//case "ShowL3_btn":
					//	new Lab3Form().Show();
					//	break;
					//case "ShowL4_btn":
					//	new Lab4Form().Show();
					//	break;
					//case "ShowL5_btn":
					//	new Lab5Form().Show();
					//	break;
			}
		}
	}
}
