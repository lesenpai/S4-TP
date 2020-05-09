using System;
using System.Windows.Forms;
using S4_TP.Lab1;
using S4_TP.Lab2;
using S4_TP.Lab3;
using S4_TP.Lab4;
using S4_TP.Lab5;
using S4_TP.Lab6;

namespace S4_TP
{
	public partial class LabManagerForm : Form
	{
		public LabManagerForm()
		{
			InitializeComponent();
		}

		private void Btn_ShowLabX_Click(object sender, EventArgs e)
		{
			switch ((sender as Button).Name)
			{
				case "BtnShowLab1":
					new Lab1Form().Show();
					break;
				case "BtnShowLab2":
					new Lab2Form().Show();
					break;
				case "BtnShowLab3":
					new Lab3Form().Show();
					break;
				case "BtnShowLab4":
					new Lab4Form().Show();
					break;
				case "BtnShowLab5":
					new Lab5Form().Show();
					break;
				case "Btn_showLab6":
					new Lab6Form().Show();
					break;
			}
		}
	}
}
