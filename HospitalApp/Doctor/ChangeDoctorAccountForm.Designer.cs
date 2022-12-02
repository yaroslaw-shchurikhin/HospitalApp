namespace HospitalApp.Doctor
{
	partial class ChangeDoctorAccountForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeDoctorAccountForm));
			this.label6 = new System.Windows.Forms.Label();
			this.tbPhone = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbLastName = new System.Windows.Forms.TextBox();
			this.labelLastName = new System.Windows.Forms.Label();
			this.tbPatronymic = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbName = new System.Windows.Forms.TextBox();
			this.labelName = new System.Windows.Forms.Label();
			this.buttonOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(400, 29);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(432, 20);
			this.label6.TabIndex = 76;
			this.label6.Text = "Поле со звёздочкой (*) - обязательное для заполнения";
			// 
			// tbPhone
			// 
			this.tbPhone.Location = new System.Drawing.Point(518, 438);
			this.tbPhone.MaxLength = 12;
			this.tbPhone.Name = "tbPhone";
			this.tbPhone.Size = new System.Drawing.Size(171, 26);
			this.tbPhone.TabIndex = 73;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(514, 414);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(142, 20);
			this.label3.TabIndex = 72;
			this.label3.Text = "Номер телефона";
			// 
			// tbLastName
			// 
			this.tbLastName.Location = new System.Drawing.Point(518, 310);
			this.tbLastName.MaxLength = 20;
			this.tbLastName.Name = "tbLastName";
			this.tbLastName.Size = new System.Drawing.Size(159, 26);
			this.tbLastName.TabIndex = 71;
			// 
			// labelLastName
			// 
			this.labelLastName.AutoSize = true;
			this.labelLastName.Location = new System.Drawing.Point(514, 286);
			this.labelLastName.Name = "labelLastName";
			this.labelLastName.Size = new System.Drawing.Size(87, 20);
			this.labelLastName.TabIndex = 70;
			this.labelLastName.Text = "Фамилия*";
			// 
			// tbPatronymic
			// 
			this.tbPatronymic.Location = new System.Drawing.Point(518, 376);
			this.tbPatronymic.MaxLength = 20;
			this.tbPatronymic.Name = "tbPatronymic";
			this.tbPatronymic.Size = new System.Drawing.Size(159, 26);
			this.tbPatronymic.TabIndex = 69;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(514, 352);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 20);
			this.label2.TabIndex = 68;
			this.label2.Text = "Отчество";
			// 
			// tbName
			// 
			this.tbName.Location = new System.Drawing.Point(518, 250);
			this.tbName.MaxLength = 20;
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(159, 26);
			this.tbName.TabIndex = 67;
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(514, 226);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(46, 20);
			this.labelName.TabIndex = 66;
			this.labelName.Text = "Имя*";
			// 
			// buttonOK
			// 
			this.buttonOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonOK.Location = new System.Drawing.Point(446, 591);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(303, 80);
			this.buttonOK.TabIndex = 65;
			this.buttonOK.Text = "Подтвердить";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// ChangeDoctorAccountForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1199, 725);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.tbPhone);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbLastName);
			this.Controls.Add(this.labelLastName);
			this.Controls.Add(this.tbPatronymic);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.buttonOK);
			this.DoubleBuffered = true;
			this.Name = "ChangeDoctorAccountForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Изменить личные данные";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tbPhone;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbLastName;
		private System.Windows.Forms.Label labelLastName;
		private System.Windows.Forms.TextBox tbPatronymic;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Button buttonOK;
	}
}