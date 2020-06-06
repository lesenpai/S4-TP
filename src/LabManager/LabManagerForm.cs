using System;
using System.Windows.Forms;

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
					new Lab1.Lab1Form().Show();
					break;
				case "BtnShowLab2":
					new Lab2.Lab2Form().Show();
					break;
				case "BtnShowLab3":
					new Lab3.Lab3Form().Show();
					break;
				case "BtnShowLab4":
					new Lab4.Lab4Form().Show();
					break;
				case "BtnShowLab5":
					new Lab5.Lab5Form().Show();
					break;
				case "Btn_showLab6":
					new Lab6.Lab6Form().Show();
					break;
				case "Btn_ShowLab7":
					new Lab7.Lab7Form().Show();
					break;
				case "Btn_ShowLab8":
					new Lab8.Lab8Form().Show();
					break;
			}
		}
	}
}
