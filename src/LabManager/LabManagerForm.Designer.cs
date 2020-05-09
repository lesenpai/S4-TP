namespace S4_TP
{
	partial class LabManagerForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.BtnShowLab1 = new System.Windows.Forms.Button();
			this.BtnShowLab2 = new System.Windows.Forms.Button();
			this.BtnShowLab3 = new System.Windows.Forms.Button();
			this.BtnShowLab5 = new System.Windows.Forms.Button();
			this.BtnShowLab4 = new System.Windows.Forms.Button();
			this.Btn_showLab6 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// BtnShowLab1
			// 
			this.BtnShowLab1.Location = new System.Drawing.Point(13, 13);
			this.BtnShowLab1.Name = "BtnShowLab1";
			this.BtnShowLab1.Size = new System.Drawing.Size(110, 48);
			this.BtnShowLab1.TabIndex = 0;
			this.BtnShowLab1.Text = "Lab 1";
			this.BtnShowLab1.UseVisualStyleBackColor = true;
			this.BtnShowLab1.Click += new System.EventHandler(this.Btn_ShowLabX_Click);
			// 
			// BtnShowLab2
			// 
			this.BtnShowLab2.Location = new System.Drawing.Point(129, 13);
			this.BtnShowLab2.Name = "BtnShowLab2";
			this.BtnShowLab2.Size = new System.Drawing.Size(110, 48);
			this.BtnShowLab2.TabIndex = 1;
			this.BtnShowLab2.Text = "Lab 2";
			this.BtnShowLab2.UseVisualStyleBackColor = true;
			this.BtnShowLab2.Click += new System.EventHandler(this.Btn_ShowLabX_Click);
			// 
			// BtnShowLab3
			// 
			this.BtnShowLab3.Location = new System.Drawing.Point(245, 13);
			this.BtnShowLab3.Name = "BtnShowLab3";
			this.BtnShowLab3.Size = new System.Drawing.Size(110, 48);
			this.BtnShowLab3.TabIndex = 3;
			this.BtnShowLab3.Text = "Lab 3";
			this.BtnShowLab3.UseVisualStyleBackColor = true;
			this.BtnShowLab3.Click += new System.EventHandler(this.Btn_ShowLabX_Click);
			// 
			// BtnShowLab5
			// 
			this.BtnShowLab5.Location = new System.Drawing.Point(129, 67);
			this.BtnShowLab5.Name = "BtnShowLab5";
			this.BtnShowLab5.Size = new System.Drawing.Size(110, 48);
			this.BtnShowLab5.TabIndex = 5;
			this.BtnShowLab5.Text = "Lab 5";
			this.BtnShowLab5.UseVisualStyleBackColor = true;
			this.BtnShowLab5.Click += new System.EventHandler(this.Btn_ShowLabX_Click);
			// 
			// BtnShowLab4
			// 
			this.BtnShowLab4.Location = new System.Drawing.Point(13, 67);
			this.BtnShowLab4.Name = "BtnShowLab4";
			this.BtnShowLab4.Size = new System.Drawing.Size(110, 48);
			this.BtnShowLab4.TabIndex = 6;
			this.BtnShowLab4.Text = "Lab 4";
			this.BtnShowLab4.UseVisualStyleBackColor = true;
			this.BtnShowLab4.Click += new System.EventHandler(this.Btn_ShowLabX_Click);
			// 
			// Btn_showLab6
			// 
			this.Btn_showLab6.Location = new System.Drawing.Point(245, 67);
			this.Btn_showLab6.Name = "Btn_showLab6";
			this.Btn_showLab6.Size = new System.Drawing.Size(110, 48);
			this.Btn_showLab6.TabIndex = 7;
			this.Btn_showLab6.Text = "Lab 6";
			this.Btn_showLab6.UseVisualStyleBackColor = true;
			this.Btn_showLab6.Click += new System.EventHandler(this.Btn_ShowLabX_Click);
			// 
			// LabManagerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(416, 241);
			this.Controls.Add(this.Btn_showLab6);
			this.Controls.Add(this.BtnShowLab4);
			this.Controls.Add(this.BtnShowLab5);
			this.Controls.Add(this.BtnShowLab3);
			this.Controls.Add(this.BtnShowLab2);
			this.Controls.Add(this.BtnShowLab1);
			this.Name = "LabManagerForm";
			this.Text = "S4. TP. All";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button BtnShowLab1;
		private System.Windows.Forms.Button BtnShowLab2;
		private System.Windows.Forms.Button BtnShowLab3;
		private System.Windows.Forms.Button BtnShowLab5;
		private System.Windows.Forms.Button BtnShowLab4;
		private System.Windows.Forms.Button Btn_showLab6;
	}
}

