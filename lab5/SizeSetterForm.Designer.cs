namespace s4_tp
{
	partial class SizeSetterForm
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
			this.tbWidth = new System.Windows.Forms.TextBox();
			this.tbHeigth = new System.Windows.Forms.TextBox();
			this.lblWidth = new System.Windows.Forms.Label();
			this.lblHeigth = new System.Windows.Forms.Label();
			this.lblHeader = new System.Windows.Forms.Label();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tbWidth
			// 
			this.tbWidth.Location = new System.Drawing.Point(68, 53);
			this.tbWidth.Name = "tbWidth";
			this.tbWidth.Size = new System.Drawing.Size(100, 20);
			this.tbWidth.TabIndex = 0;
			this.tbWidth.Text = "600";
			// 
			// tbHeigth
			// 
			this.tbHeigth.Location = new System.Drawing.Point(68, 92);
			this.tbHeigth.Name = "tbHeigth";
			this.tbHeigth.Size = new System.Drawing.Size(100, 20);
			this.tbHeigth.TabIndex = 1;
			this.tbHeigth.Text = "300";
			// 
			// lblWidth
			// 
			this.lblWidth.AutoSize = true;
			this.lblWidth.Location = new System.Drawing.Point(27, 56);
			this.lblWidth.Name = "lblWidth";
			this.lblWidth.Size = new System.Drawing.Size(35, 13);
			this.lblWidth.TabIndex = 2;
			this.lblWidth.Text = "Width";
			// 
			// lblHeigth
			// 
			this.lblHeigth.AutoSize = true;
			this.lblHeigth.Location = new System.Drawing.Point(27, 95);
			this.lblHeigth.Name = "lblHeigth";
			this.lblHeigth.Size = new System.Drawing.Size(38, 13);
			this.lblHeigth.TabIndex = 3;
			this.lblHeigth.Text = "Heigth";
			// 
			// lblHeader
			// 
			this.lblHeader.AutoSize = true;
			this.lblHeader.Location = new System.Drawing.Point(27, 9);
			this.lblHeader.Name = "lblHeader";
			this.lblHeader.Size = new System.Drawing.Size(75, 13);
			this.lblHeader.TabIndex = 4;
			this.lblHeader.Text = "Set image size";
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(27, 125);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 5;
			this.btnOk.Text = "Ok";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(129, 125);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(100, 23);
			this.btnCancel.TabIndex = 6;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// SizeSetterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(241, 160);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.lblHeader);
			this.Controls.Add(this.lblHeigth);
			this.Controls.Add(this.lblWidth);
			this.Controls.Add(this.tbHeigth);
			this.Controls.Add(this.tbWidth);
			this.Name = "SizeSetterForm";
			this.Text = "SizeSetterForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbWidth;
		private System.Windows.Forms.TextBox tbHeigth;
		private System.Windows.Forms.Label lblWidth;
		private System.Windows.Forms.Label lblHeigth;
		private System.Windows.Forms.Label lblHeader;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancel;
	}
}