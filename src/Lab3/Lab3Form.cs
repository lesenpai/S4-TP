using System;
using System.Windows.Forms;
using System.IO;
using S4_TP.About;

namespace S4_TP.Lab3
{
	public partial class Lab3Form : Form
	{
		private string _filename;
		private const string APP_NAME = "Copy Paster Deamon";
		private const string CAPTURE_RIGHT_SIDE = " - " + APP_NAME;
		private const string DEFAULT_FILE_NAME = "untitled";
		private AboutForm aboutForm;
		// Flags
		private bool isFileOpen = false,
			isFileSaved = true,
			wasFileSwitched = false;

		public Lab3Form()
		{
			DoubleBuffered = true;
			InitializeComponent();
		}
		protected override void WndProc(ref Message m)
		{
			// WM_CLOSE
			if (m.Msg == 0x0010)
			{
				if (isFileSaved)
				{
					base.WndProc(ref m);
					return;
				}
				var dlg_result = MessageBox.Show("Save file?", APP_NAME, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
				switch (dlg_result)
				{
					case DialogResult.Yes:
						Save(_filename);
						isFileSaved = true;
						break;
					case DialogResult.No:
						break;
					case DialogResult.Cancel:
						return;
					// If messagebox was closed
					default:
						return;
				}
			}
			base.WndProc(ref m);
		}

		private void F3Form_Load(object sender, EventArgs e)
		{
			Text = DEFAULT_FILE_NAME + CAPTURE_RIGHT_SIDE;
		}

		private void Save(string path)
		{
			rtb.SaveFile(path);
		}

		private void SaveAs()
		{
			if (SaveFD.ShowDialog() == DialogResult.OK)
			{
				_filename = SaveFD.FileName;
				var prev_filename = _filename;
				try
				{
					if (_filename.EndsWith(".rtf"))
						rtb.SaveFile(_filename, RichTextBoxStreamType.RichText);
					else
						rtb.SaveFile(_filename, RichTextBoxStreamType.PlainText);
					_filename = SaveFD.FileName;
				}
				catch (Exception)
				{
					_filename = prev_filename;
					return;
				}
				/* Сохранение прошло успешно */
				// UI
				Text = _filename + CAPTURE_RIGHT_SIDE;
				isFileSaved = true;
				isFileOpen = true;
			}
		}

		/* Open file */
		private void Open_TSMI_Click(object sender, EventArgs e)
		{
			try
			{
				if (OpenFD.ShowDialog() == DialogResult.OK)
				{
					_filename = OpenFD.FileName;
					if (OpenFD.FileName.EndsWith(".rtf"))
						rtb.LoadFile(_filename, RichTextBoxStreamType.RichText);
					else
						rtb.LoadFile(_filename, RichTextBoxStreamType.PlainText);
					Text = _filename + CAPTURE_RIGHT_SIDE;
					isFileOpen = true;
					isFileSaved = true;
				}
			}
			catch (Exception ex)
			{
				isFileOpen = false;
				Text = DEFAULT_FILE_NAME + CAPTURE_RIGHT_SIDE;
				MessageBox.Show(ex.Message);
			}
		}

		// SAVE
		private void Save_TSMI_Click(object sender, EventArgs e)
		{
			if (File.Exists(_filename))
				Save(_filename);
			else
				SaveAs();
			if (!isFileSaved)
			{
				isFileSaved = true;
				Text = Text.Substring(1);
			}
		}

		private void Text_RTB_TextChanged(object sender, EventArgs e)
		{
			if(isFileSaved && !wasFileSwitched)
			{
				Text = "*" + Text;
				isFileSaved = false;
			}
			if (wasFileSwitched)
				wasFileSwitched = false;
		}

		private void SelectionFont_TSMI_Click(object sender, EventArgs e)
		{
			FontDlg.Font = rtb.Font;
			if (FontDlg.ShowDialog() == DialogResult.OK)
				rtb.SelectionFont = FontDlg.Font;
		}

		private void SelectionColor_TSMI_Click(object sender, EventArgs e)
		{
			colorDlg.Color = rtb.BackColor;
			if (colorDlg.ShowDialog() == DialogResult.OK)
				rtb.SelectionBackColor = colorDlg.Color;
		}

		private void BackgroundColor_TSMI_Click(object sender, EventArgs e)
		{
			if (colorDlg.ShowDialog() == DialogResult.OK)
				rtb.BackColor = colorDlg.Color;
		}

		private void Copy_TSMI_Click(object sender, EventArgs e)
		{
			rtb.Copy();
		}

		private void Cut_TSMI_Click(object sender, EventArgs e)
		{
			rtb.Cut();
		}

		private void Paste_TSMI_Click(object sender, EventArgs e)
		{
			rtb.Paste();
		}

		private void Font_TSMI_Click(object sender, EventArgs e)
		{
			if (FontDlg.ShowDialog() == DialogResult.Cancel)
				return;
			rtb.Font = FontDlg.Font;
			rtb.ForeColor = FontDlg.Color;
		}

		// EXIT
		private void Exit_TSMI_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void TsmiNew_Click(object sender, EventArgs e)
		{
			if (isFileOpen)
			{
				var dlg_res = MessageBox.Show("Save file?", APP_NAME, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
				if (dlg_res == DialogResult.Yes)
					Save(_filename);
				_filename = DEFAULT_FILE_NAME;
				Text = _filename + CAPTURE_RIGHT_SIDE;
				rtb.Text = "";
				isFileSaved = true;
				wasFileSwitched = true;
			}
			else
			{
				var dlg_res = MessageBox.Show("Save file?", APP_NAME, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
				if (dlg_res == DialogResult.Yes)
				{
					SaveAs();
					_filename = DEFAULT_FILE_NAME;
					Text = _filename + CAPTURE_RIGHT_SIDE;
					rtb.Text = "";
					isFileSaved = true;
				}
			}
		}

		private void TsmiSelectionTextColor_Click(object sender, EventArgs e)
		{
			colorDlg.Color = rtb.ForeColor;
			if (colorDlg.ShowDialog() == DialogResult.OK)
				rtb.SelectionColor = colorDlg.Color;
		}

		private void About_TSMI_Click(object sender, EventArgs e)
		{
			if (aboutForm == null || aboutForm.IsDisposed)
				aboutForm = new AboutForm();
			aboutForm.SetLabNumber("3").Show();
		}

		private void SaveAs_TSMI_Click(object sender, EventArgs e)
		{
			SaveAs();
		}
	}
}
