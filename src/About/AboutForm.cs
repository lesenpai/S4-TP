using System.Windows.Forms;

namespace S4_TP.About
{
	public partial class AboutForm : Form
	{
		private const string _LABEL_MASK = "<N>";
		public AboutForm()
		{
			InitializeComponent();
		}

		private void Author_LL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("http://xn--80ad0a7f.xn--c1a4ad9b.xn--p1ai/");
		}

		public AboutForm SetLabNumber(string number)
		{
			Header_lbl.Text = Header_lbl.Text.Replace(_LABEL_MASK, number);
			return this;
		}
	}
}
