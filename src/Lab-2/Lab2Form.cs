using System;
using System.IO;
using System.Windows.Forms;
using S4_TP.About;

namespace S4_TP.Lab2
{
    public partial class Lab2Form : Form
    {
        private const string APP_NAME = "Blocknotik";
        private const string CAPTURE_RIGHT_SIDE = " - " + APP_NAME;
        private const string DEFAULT_FILE_NAME = "untitled";
        private AboutForm aboutForm;
        private string _filename;
        // Flags
        private bool isFileOpen = false,
            isFileSaved = true,
            wasFileSwitched = false;
        private const int WM_CLOSE = 0x0010;

        public Lab2Form()
        {
            DoubleBuffered = true;
            InitializeComponent();
        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_CLOSE)
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

        private void F2Form_Load(object sender, EventArgs e)
        {
            Text = DEFAULT_FILE_NAME + CAPTURE_RIGHT_SIDE;
        }

        private void Save_tsmi_Click(object sender, EventArgs e)
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

        private void Save(string filename)
        {
            File.WriteAllText(filename, tb.Text);
        }

        private void SaveAs()
        {
            if (Save_sfd.ShowDialog() == DialogResult.OK)
            {
                var prev_filename = _filename;
                try
                {
                    _filename = Save_sfd.FileName;
                    File.WriteAllText(_filename, tb.Text);
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
            DialogResult ShowMessageBox_SaveFile() => MessageBox.Show("Save file?", APP_NAME, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            void UpdateState()
            {
                // Data
                _filename = DEFAULT_FILE_NAME;
                tb.Text = "";
                // UI
                Text = _filename + CAPTURE_RIGHT_SIDE;
                // Flags
                isFileSaved = true;
            }

            if (isFileOpen)
            {
                if (ShowMessageBox_SaveFile() == DialogResult.Yes)
                    Save(_filename);
                UpdateState();
                wasFileSwitched = true;
            }
            else
            {
                if (ShowMessageBox_SaveFile() == DialogResult.Yes)
                {
                    SaveAs();
                    UpdateState();
                }
            }
        }

        private void TsmiTextColor_Click(object sender, EventArgs e)
        {
            if (cdTextColor.ShowDialog() == DialogResult.OK)
                tb.ForeColor = cdTextColor.Color;
        }

        private void Open_tsmi_Click(object sender, EventArgs e)
        {
            Open_ofd.ShowDialog();
        }
        private void Open_ofd_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                _filename = Open_ofd.FileName;
                tb.Text = File.ReadAllText(_filename);
                Text = _filename + CAPTURE_RIGHT_SIDE;
                isFileOpen = true;
                isFileSaved = true;
                tb.Select(0, 0);
            }
            catch (Exception ex)
            {
                isFileOpen = false;
                Text = DEFAULT_FILE_NAME + CAPTURE_RIGHT_SIDE;
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

