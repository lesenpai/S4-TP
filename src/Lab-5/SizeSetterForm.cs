using System;
using System.Windows.Forms;

namespace S4_TP
{
	public partial class SizeSetterForm : Form
	{
		public SizeSetterResult Result { get; set; }
		private const int WM_CLOSE = 0x0010;
		public SizeSetterForm()
		{
			InitializeComponent();
			Result = new SizeSetterResult();
		}

		/*protected override void WndProc(ref Message m)
		{
			// WM_CLOSE
			if (m.Msg == WM_CLOSE)
			{
				if(Result.State == null)
					Result.State = DialogResult.Cancel;
			}
			base.WndProc(ref m);
		}*/

		private void BtnOk_Click(object sender, EventArgs e)
		{
			try
			{
				Result.Width = int.Parse(tbWidth.Text);
				Result.Heigth = int.Parse(tbHeigth.Text);
				if (Result.Width < 1 || Result.Heigth < 1)
					throw new Exception();

				Result.State = DialogResult.Yes;
			}
			catch (Exception)
			{
				Result.State = DialogResult.No;
			}
			Close();
		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			Result.State = DialogResult.Cancel;
			Close();
		}
	}
}

public class SizeSetterResult
{
	public DialogResult State { get; set; }
	public int Width { get; set; }
	public int Heigth { get; set; }
}
