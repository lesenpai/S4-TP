namespace S4_TP.About
{
	partial class AboutForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}
		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Header_lbl = new System.Windows.Forms.Label();
			this.Author_LL = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// Header_lbl
			// 
			this.Header_lbl.AutoSize = true;
			this.Header_lbl.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Header_lbl.Location = new System.Drawing.Point(37, 41);
			this.Header_lbl.Name = "Header_lbl";
			this.Header_lbl.Size = new System.Drawing.Size(164, 18);
			this.Header_lbl.TabIndex = 0;
			this.Header_lbl.Text = "The TP lab №<N> by";
			// 
			// Author_LL
			// 
			this.Author_LL.AutoSize = true;
			this.Author_LL.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Author_LL.Location = new System.Drawing.Point(184, 69);
			this.Author_LL.Name = "Author_LL";
			this.Author_LL.Size = new System.Drawing.Size(103, 18);
			this.Author_LL.TabIndex = 1;
			this.Author_LL.TabStop = true;
			this.Author_LL.Text = "Lev Platonov";
			this.Author_LL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Author_LL_LinkClicked);
			// 
			// AboutForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(354, 141);
			this.Controls.Add(this.Author_LL);
			this.Controls.Add(this.Header_lbl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "AboutForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "About";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Header_lbl;
		private System.Windows.Forms.LinkLabel Author_LL;
	}
}