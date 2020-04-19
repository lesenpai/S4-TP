using System;
using System.Windows.Forms;
using System.IO;

namespace s4_tp
{
	public partial class Lab3Form : Form
	{
		private string fileName;
		private const string APP_NAME = "Copy Paster Deamon";
		private const string TEXT_RSIDE = " - " + APP_NAME;
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
						Save(fileName);
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
			Text = DEFAULT_FILE_NAME + TEXT_RSIDE;
		}
		private void Save(string path)
		{
			Text_RTB.SaveFile(path);
		}
		private void SaveAs()
		{
			if (SaveFD.ShowDialog() == DialogResult.OK)
			{
				fileName = SaveFD.FileName;
				File.WriteAllText(fileName, Text_RTB.Text);
			}
		}

		// OPEN
		private void Open_TSMI_Click(object sender, EventArgs e)
		{
			try
			{
				/*
					TO-DO: добавить ветвление способа взятия текста файла по его формату
				*/
				if (OpenFD.ShowDialog() == DialogResult.OK)
				{
					fileName = OpenFD.FileName;
					if (OpenFD.FileName.EndsWith(".rtf"))
						Text_RTB.LoadFile(fileName);
					else
						Text_RTB.Text = File.ReadAllText(fileName);
					Text = fileName + TEXT_RSIDE;
					isFileOpen = true;
					isFileSaved = true;
				}
			}
			catch (Exception ex)
			{
				isFileOpen = false;
				Text = DEFAULT_FILE_NAME + TEXT_RSIDE;
				MessageBox.Show(ex.Message);
			}
		}

		// SAVE
		private void Save_TSMI_Click(object sender, EventArgs e)
		{
			if (File.Exists(fileName))
				Save(fileName);
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
			FontDlg.Font = Text_RTB.Font;
			if (FontDlg.ShowDialog() == DialogResult.OK)
				Text_RTB.SelectionFont = FontDlg.Font;
		}

		private void SelectionColor_TSMI_Click(object sender, EventArgs e)
		{
			ColorDlg.Color = Text_RTB.BackColor;
			if (ColorDlg.ShowDialog() == DialogResult.OK)
				Text_RTB.SelectionBackColor = ColorDlg.Color;
		}

		private void BackgroundColor_TSMI_Click(object sender, EventArgs e)
		{
			if (ColorDlg.ShowDialog() == DialogResult.Cancel)
				return;
			Text_RTB.BackColor = ColorDlg.Color;
		}

		private void Copy_TSMI_Click(object sender, EventArgs e)
		{
			Text_RTB.Copy();
		}

		private void Cut_TSMI_Click(object sender, EventArgs e)
		{
			Text_RTB.Cut();
		}

		private void Paste_TSMI_Click(object sender, EventArgs e)
		{
			Text_RTB.Paste();
		}

		private void Font_TSMI_Click(object sender, EventArgs e)
		{
			if (FontDlg.ShowDialog() == DialogResult.Cancel)
				return;
			Text_RTB.Font = FontDlg.Font;
			Text_RTB.ForeColor = FontDlg.Color;
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
				{
					Save(fileName);
					fileName = DEFAULT_FILE_NAME;
					Text = fileName + TEXT_RSIDE;
					Text_RTB.Text = "";
					isFileSaved = true;
					wasFileSwitched = true;
				}
				else
				{
					fileName = DEFAULT_FILE_NAME;
					Text = fileName + TEXT_RSIDE;
					Text_RTB.Text = "";
					isFileSaved = true;
					wasFileSwitched = true;
				}
			}
			else
			{
				var dlg_res = MessageBox.Show("Save file?", APP_NAME, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
				if (dlg_res == DialogResult.Yes)
				{
					SaveAs();
					fileName = DEFAULT_FILE_NAME;
					Text = fileName + TEXT_RSIDE;
					Text_RTB.Text = "";
					isFileSaved = true;
				}
			}
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
