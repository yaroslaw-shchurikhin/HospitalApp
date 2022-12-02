namespace HospitalApp.Patient
{
	partial class AddPatientOrderForm
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
			this.labelDoctorSpec = new System.Windows.Forms.Label();
			this.cbDoctorSpec = new System.Windows.Forms.ComboBox();
			this.labelDoctorName = new System.Windows.Forms.Label();
			this.cbDoctorName = new System.Windows.Forms.ComboBox();
			this.buttonOK = new System.Windows.Forms.Button();
			this.labelDate = new System.Windows.Forms.Label();
			this.cbDate = new System.Windows.Forms.ComboBox();
			this.cbTime = new System.Windows.Forms.ComboBox();
			this.labelTime = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelDoctorSpec
			// 
			this.labelDoctorSpec.AutoSize = true;
			this.labelDoctorSpec.Location = new System.Drawing.Point(277, 19);
			this.labelDoctorSpec.Name = "labelDoctorSpec";
			this.labelDoctorSpec.Size = new System.Drawing.Size(254, 20);
			this.labelDoctorSpec.TabIndex = 0;
			this.labelDoctorSpec.Text = "Выберите специальность врача";
			// 
			// cbDoctorSpec
			// 
			this.cbDoctorSpec.FormattingEnabled = true;
			this.cbDoctorSpec.Location = new System.Drawing.Point(281, 42);
			this.cbDoctorSpec.Name = "cbDoctorSpec";
			this.cbDoctorSpec.Size = new System.Drawing.Size(250, 28);
			this.cbDoctorSpec.TabIndex = 1;
			this.cbDoctorSpec.SelectedIndexChanged += new System.EventHandler(this.cbDoctorSpec_SelectedIndexChanged);
			// 
			// labelDoctorName
			// 
			this.labelDoctorName.AutoSize = true;
			this.labelDoctorName.Location = new System.Drawing.Point(277, 93);
			this.labelDoctorName.Name = "labelDoctorName";
			this.labelDoctorName.Size = new System.Drawing.Size(134, 20);
			this.labelDoctorName.TabIndex = 2;
			this.labelDoctorName.Text = "Выберите врача";
			// 
			// cbDoctorName
			// 
			this.cbDoctorName.FormattingEnabled = true;
			this.cbDoctorName.Location = new System.Drawing.Point(281, 116);
			this.cbDoctorName.Name = "cbDoctorName";
			this.cbDoctorName.Size = new System.Drawing.Size(250, 28);
			this.cbDoctorName.TabIndex = 3;
			this.cbDoctorName.SelectedIndexChanged += new System.EventHandler(this.cbDoctorName_SelectedIndexChanged);
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new System.Drawing.Point(281, 353);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(236, 64);
			this.buttonOK.TabIndex = 4;
			this.buttonOK.Text = "Записаться к врачу";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// labelDate
			// 
			this.labelDate.AutoSize = true;
			this.labelDate.Location = new System.Drawing.Point(277, 167);
			this.labelDate.Name = "labelDate";
			this.labelDate.Size = new System.Drawing.Size(185, 20);
			this.labelDate.TabIndex = 27;
			this.labelDate.Text = "Выберите дату приёма";
			// 
			// cbDate
			// 
			this.cbDate.FormattingEnabled = true;
			this.cbDate.Location = new System.Drawing.Point(281, 204);
			this.cbDate.Name = "cbDate";
			this.cbDate.Size = new System.Drawing.Size(181, 28);
			this.cbDate.TabIndex = 28;
			this.cbDate.SelectedIndexChanged += new System.EventHandler(this.cbDate_SelectedIndexChanged);
			// 
			// cbTime
			// 
			this.cbTime.FormattingEnabled = true;
			this.cbTime.Location = new System.Drawing.Point(281, 293);
			this.cbTime.Name = "cbTime";
			this.cbTime.Size = new System.Drawing.Size(181, 28);
			this.cbTime.TabIndex = 30;
			// 
			// labelTime
			// 
			this.labelTime.AutoSize = true;
			this.labelTime.Location = new System.Drawing.Point(277, 256);
			this.labelTime.Name = "labelTime";
			this.labelTime.Size = new System.Drawing.Size(136, 20);
			this.labelTime.TabIndex = 29;
			this.labelTime.Text = "Выберите время";
			// 
			// AddPatientOrderForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.cbTime);
			this.Controls.Add(this.labelTime);
			this.Controls.Add(this.cbDate);
			this.Controls.Add(this.labelDate);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.cbDoctorName);
			this.Controls.Add(this.labelDoctorName);
			this.Controls.Add(this.cbDoctorSpec);
			this.Controls.Add(this.labelDoctorSpec);
			this.Name = "AddPatientOrderForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Запись на приём";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelDoctorSpec;
		private System.Windows.Forms.ComboBox cbDoctorSpec;
		private System.Windows.Forms.Label labelDoctorName;
		private System.Windows.Forms.ComboBox cbDoctorName;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Label labelDate;
		private System.Windows.Forms.ComboBox cbDate;
		private System.Windows.Forms.ComboBox cbTime;
		private System.Windows.Forms.Label labelTime;
	}
}