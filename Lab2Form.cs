using System;
using System.IO;
using System.Windows.Forms;

namespace s4_tp
{
    public partial class Lab2Form : Form
    {
        private const string APP_NAME = "Blocknotik";
        private const string TEXT_RSIDE = " - " + APP_NAME;
        private const string DEFAULT_FILE_NAME = "untitled";
        private AboutForm aboutForm;
        private string fileName;
        // Flags
        private bool isFileOpen = false,
            isFileSaved = true,
            wasFileSwitched = false;

        public Lab2Form()
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
                var dlg_res = MessageBox.Show("Save file?", APP_NAME, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (dlg_res == DialogResult.OK)
                {
                    Save(fileName);
                    isFileSaved = true;
                }
                else
                {
                    base.WndProc(ref m);
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private void F2Form_Load(object sender, EventArgs e)
        {
            Text = DEFAULT_FILE_NAME + TEXT_RSIDE;
        }

        private void Save_tsmi_Click(object sender, EventArgs e)
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

        private void Save(string filename)
        {
            File.WriteAllText(filename, tb.Text);
        }

        private void SaveAs()
        {
            if (Save_sfd.ShowDialog() == DialogResult.OK)
                File.WriteAllText(Save_sfd.FileName, tb.Text);
        }

        private void Exit_tsmi_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Tb_TextChanged(object sender, EventArgs e)
        {
            if(isFileSaved && !wasFileSwitched)
            {
                Text = "*" + Text;
                isFileSaved = false;
            }
            if (wasFileSwitched)
                wasFileSwitched = false;
        }

        private void Font_tsmi_Click(object sender, EventArgs e)
        {
            if (Font_dlg.ShowDialog() == DialogResult.Cancel)
                return;

            tb.Font = Font_dlg.Font;
            tb.ForeColor = Font_dlg.Color;
        }

        private void BackgroundColor_tsmi_Click(object sender, EventArgs e)
        {
            if (cdBackgroundColor.ShowDialog() == DialogResult.Cancel)
                return;

            tb.BackColor = cdBackgroundColor.Color;
        }

        private void SaveAs_tsmi_Click(object sender, EventArgs e)
        {
            SaveAs();
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
                    tb.Text = "";
                    isFileSaved = true;
                    wasFileSwitched = true;
                }
                else
                {
                    fileName = DEFAULT_FILE_NAME;
                    Text = fileName + TEXT_RSIDE;
                    tb.Text = "";
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
                    tb.Text = "";
                    isFileSaved = true;
                }
            }
        }

        private void Open_tsmi_Click(object sender, EventArgs e)
        {
            Open_ofd.ShowDialog();
        }

        private void TsmiTextColor_Click(object sender, EventArgs e)
        {
            if (cdTextColor.ShowDialog() == DialogResult.Cancel)
                return;

            tb.ForeColor = cdTextColor.Color;
        }

        private void Open_ofd_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                fileName = Open_ofd.FileName;
                tb.Text = File.ReadAllText(fileName);
                Text = fileName + TEXT_RSIDE;
                isFileOpen = true;
                isFileSaved = true;
                tb.Select(0, 0);
            }
            catch (Exception ex)
            {
                isFileOpen = false;
                Text = DEFAULT_FILE_NAME + TEXT_RSIDE;
                MessageBox.Show(ex.Message);
            }
        }

        private void About_TSMI_Click(object sender, EventArgs e)
        {
            if (aboutForm == null || aboutForm.IsDisposed)
                aboutForm = new AboutForm();
            aboutForm.SetLabNumber("2").Show();
        }
    }
}

