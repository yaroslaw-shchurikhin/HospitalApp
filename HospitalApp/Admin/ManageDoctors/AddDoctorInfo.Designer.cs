namespace HospitalApp.Admin.ManageDoctors
{
	partial class AddDoctorInfo
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
			this.tbPhone = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbLastName = new System.Windows.Forms.TextBox();
			this.labelLastName = new System.Windows.Forms.Label();
			this.tbPatronymic = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbName = new System.Windows.Forms.TextBox();
			this.labelName = new System.Windows.Forms.Label();
			this.buttonOK = new System.Windows.Forms.Button();
			this.label1ChooseSpecs = new System.Windows.Forms.Label();
			this.labelAllInfo = new System.Windows.Forms.Label();
			this.clbSpecs = new System.Windows.Forms.CheckedListBox();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.labelPassword = new System.Windows.Forms.Label();
			this.tbPasspNum = new System.Windows.Forms.TextBox();
			this.labelPassportNum = new System.Windows.Forms.Label();
			this.cbPosition = new System.Windows.Forms.ComboBox();
			this.labelPos = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// tbPhone
			// 
			this.tbPhone.Location = new System.Drawing.Point(122, 391);
			this.tbPhone.MaxLength = 12;
			this.tbPhone.Name = "tbPhone";
			this.tbPhone.Size = new System.Drawing.Size(171, 26);
			this.tbPhone.TabIndex = 82;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(118, 367);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(142, 20);
			this.label3.TabIndex = 81;
			this.label3.Text = "Номер телефона";
			// 
			// tbLastName
			// 
			this.tbLastName.Location = new System.Drawing.Point(122, 263);
			this.tbLastName.MaxLength = 20;
			this.tbLastName.Name = "tbLastName";
			this.tbLastName.Size = new System.Drawing.Size(159, 26);
			this.tbLastName.TabIndex = 80;
			// 
			// labelLastName
			// 
			this.labelLastName.AutoSize = true;
			this.labelLastName.Location = new System.Drawing.Point(118, 239);
			this.labelLastName.Name = "labelLastName";
			this.labelLastName.Size = new System.Drawing.Size(87, 20);
			this.labelLastName.TabIndex = 79;
			this.labelLastName.Text = "Фамилия*";
			// 
			// tbPatronymic
			// 
			this.tbPatronymic.Location = new System.Drawing.Point(122, 329);
			this.tbPatronymic.MaxLength = 20;
			this.tbPatronymic.Name = "tbPatronymic";
			this.tbPatronymic.Size = new System.Drawing.Size(159, 26);
			this.tbPatronymic.TabIndex = 78;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(118, 305);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 20);
			this.label2.TabIndex = 77;
			this.label2.Text = "Отчество";
			// 
			// tbName
			// 
			this.tbName.Location = new System.Drawing.Point(122, 203);
			this.tbName.MaxLength = 20;
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(159, 26);
			this.tbName.TabIndex = 76;
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(118, 179);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(46, 20);
			this.labelName.TabIndex = 75;
			this.labelName.Text = "Имя*";
			// 
			// buttonOK
			// 
			this.buttonOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonOK.Location = new System.Drawing.Point(464, 608);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(303, 80);
			this.buttonOK.TabIndex = 74;
			this.buttonOK.Text = "Подтвердить";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// label1ChooseSpecs
			// 
			this.label1ChooseSpecs.AutoSize = true;
			this.label1ChooseSpecs.Location = new System.Drawing.Point(726, 119);
			this.label1ChooseSpecs.Name = "label1ChooseSpecs";
			this.label1ChooseSpecs.Size = new System.Drawing.Size(205, 20);
			this.label1ChooseSpecs.TabIndex = 83;
			this.label1ChooseSpecs.Text = "Выберите специальности";
			// 
			// labelAllInfo
			// 
			this.labelAllInfo.AutoSize = true;
			this.labelAllInfo.Location = new System.Drawing.Point(122, 135);
			this.labelAllInfo.Name = "labelAllInfo";
			this.labelAllInfo.Size = new System.Drawing.Size(163, 20);
			this.labelAllInfo.TabIndex = 84;
			this.labelAllInfo.Text = "Общая информация";
			// 
			// clbSpecs
			// 
			this.clbSpecs.FormattingEnabled = true;
			this.clbSpecs.Location = new System.Drawing.Point(730, 163);
			this.clbSpecs.Name = "clbSpecs";
			this.clbSpecs.Size = new System.Drawing.Size(310, 234);
			this.clbSpecs.TabIndex = 85;
			// 
			// tbPassword
			// 
			this.tbPassword.Location = new System.Drawing.Point(531, 551);
			this.tbPassword.MaxLength = 20;
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.Size = new System.Drawing.Size(159, 26);
			this.tbPassword.TabIndex = 87;
			this.tbPassword.UseSystemPasswordChar = true;
			// 
			// labelPassword
			// 
			this.labelPassword.AutoSize = true;
			this.labelPassword.Location = new System.Drawing.Point(527, 510);
			this.labelPassword.Name = "labelPassword";
			this.labelPassword.Size = new System.Drawing.Size(169, 20);
			this.labelPassword.TabIndex = 86;
			this.labelPassword.Text = "Придумайте пароль*";
			// 
			// tbPasspNum
			// 
			this.tbPasspNum.Location = new System.Drawing.Point(122, 461);
			this.tbPasspNum.MaxLength = 10;
			this.tbPasspNum.Name = "tbPasspNum";
			this.tbPasspNum.Size = new System.Drawing.Size(171, 26);
			this.tbPasspNum.TabIndex = 89;
			this.tbPasspNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPasspNum_KeyPress);
			// 
			// labelPassportNum
			// 
			this.labelPassportNum.AutoSize = true;
			this.labelPassportNum.Location = new System.Drawing.Point(118, 437);
			this.labelPassportNum.Name = "labelPassportNum";
			this.labelPassportNum.Size = new System.Drawing.Size(140, 20);
			this.labelPassportNum.TabIndex = 88;
			this.labelPassportNum.Text = "Номер паспорта*";
			// 
			// cbPosition
			// 
			this.cbPosition.FormattingEnabled = true;
			this.cbPosition.Location = new System.Drawing.Point(730, 455);
			this.cbPosition.Name = "cbPosition";
			this.cbPosition.Size = new System.Drawing.Size(201, 28);
			this.cbPosition.TabIndex = 90;
			// 
			// labelPos
			// 
			this.labelPos.AutoSize = true;
			this.labelPos.Location = new System.Drawing.Point(730, 429);
			this.labelPos.Name = "labelPos";
			this.labelPos.Size = new System.Drawing.Size(174, 20);
			this.labelPos.TabIndex = 91;
			this.labelPos.Text = "Выберите должность";
			// 
			// AddDoctorInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1199, 725);
			this.Controls.Add(this.labelPos);
			this.Controls.Add(this.cbPosition);
			this.Controls.Add(this.tbPasspNum);
			this.Controls.Add(this.labelPassportNum);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.labelPassword);
			this.Controls.Add(this.clbSpecs);
			this.Controls.Add(this.labelAllInfo);
			this.Controls.Add(this.label1ChooseSpecs);
			this.Controls.Add(this.tbPhone);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbLastName);
			this.Controls.Add(this.labelLastName);
			this.Controls.Add(this.tbPatronymic);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.buttonOK);
			this.Name = "AddDoctorInfo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Добавление нового врача";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddDoctorInfo_FormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbPhone;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbLastName;
		private System.Windows.Forms.Label labelLastName;
		private System.Windows.Forms.TextBox tbPatronymic;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Label label1ChooseSpecs;
		private System.Windows.Forms.Label labelAllInfo;
		private System.Windows.Forms.CheckedListBox clbSpecs;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.Label labelPassword;
		private System.Windows.Forms.TextBox tbPasspNum;
		private System.Windows.Forms.Label labelPassportNum;
		private System.Windows.Forms.ComboBox cbPosition;
		private System.Windows.Forms.Label labelPos;
	}
}