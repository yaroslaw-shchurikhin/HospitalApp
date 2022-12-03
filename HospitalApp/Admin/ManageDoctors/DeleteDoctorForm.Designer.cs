namespace HospitalApp.Admin.ManageDoctors
{
	partial class DeleteDoctorForm
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
			this.labelName = new System.Windows.Forms.Label();
			this.cbNames = new System.Windows.Forms.ComboBox();
			this.buttonOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(241, 67);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(47, 20);
			this.labelName.TabIndex = 0;
			this.labelName.Text = "ФИО";
			// 
			// cbNames
			// 
			this.cbNames.FormattingEnabled = true;
			this.cbNames.Location = new System.Drawing.Point(103, 100);
			this.cbNames.Name = "cbNames";
			this.cbNames.Size = new System.Drawing.Size(322, 28);
			this.cbNames.TabIndex = 1;
			this.cbNames.SelectedIndexChanged += new System.EventHandler(this.cbNames_SelectedIndexChanged);
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new System.Drawing.Point(174, 188);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(175, 55);
			this.buttonOK.TabIndex = 2;
			this.buttonOK.Text = "Подтвердить";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Visible = false;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// DeleteDoctorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(555, 274);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.cbNames);
			this.Controls.Add(this.labelName);
			this.Name = "DeleteDoctorForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Увольнение врача";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.ComboBox cbNames;
		private System.Windows.Forms.Button buttonOK;
	}
}