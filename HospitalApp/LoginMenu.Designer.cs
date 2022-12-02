namespace HospitalApp
{
	partial class LoginMenu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginMenu));
			this.buttonConnect = new System.Windows.Forms.Button();
			this.tbPasspNum1 = new System.Windows.Forms.TextBox();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.tbPasspNum2 = new System.Windows.Forms.TextBox();
			this.buttonNoAcc = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.checkBoxPasswordShow = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// buttonConnect
			// 
			this.buttonConnect.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.buttonConnect.Location = new System.Drawing.Point(502, 461);
			this.buttonConnect.Name = "buttonConnect";
			this.buttonConnect.Size = new System.Drawing.Size(178, 106);
			this.buttonConnect.TabIndex = 0;
			this.buttonConnect.Text = "Войти";
			this.buttonConnect.UseVisualStyleBackColor = false;
			this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
			// 
			// tbPasspNum1
			// 
			this.tbPasspNum1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbPasspNum1.Location = new System.Drawing.Point(480, 252);
			this.tbPasspNum1.MaxLength = 4;
			this.tbPasspNum1.Name = "tbPasspNum1";
			this.tbPasspNum1.Size = new System.Drawing.Size(82, 26);
			this.tbPasspNum1.TabIndex = 2;
			this.tbPasspNum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPasspNum1_KeyPress);
			// 
			// tbPassword
			// 
			this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbPassword.Location = new System.Drawing.Point(480, 329);
			this.tbPassword.MaxLength = 20;
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.Size = new System.Drawing.Size(229, 26);
			this.tbPassword.TabIndex = 3;
			this.tbPassword.UseSystemPasswordChar = true;
			// 
			// tbPasspNum2
			// 
			this.tbPasspNum2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbPasspNum2.Location = new System.Drawing.Point(579, 252);
			this.tbPasspNum2.MaxLength = 6;
			this.tbPasspNum2.Name = "tbPasspNum2";
			this.tbPasspNum2.Size = new System.Drawing.Size(130, 26);
			this.tbPasspNum2.TabIndex = 4;
			this.tbPasspNum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPasspNum2_KeyPress);
			// 
			// buttonNoAcc
			// 
			this.buttonNoAcc.BackColor = System.Drawing.SystemColors.Info;
			this.buttonNoAcc.Location = new System.Drawing.Point(525, 605);
			this.buttonNoAcc.Name = "buttonNoAcc";
			this.buttonNoAcc.Size = new System.Drawing.Size(141, 36);
			this.buttonNoAcc.TabIndex = 5;
			this.buttonNoAcc.Text = "Нет аккаунта?";
			this.buttonNoAcc.UseVisualStyleBackColor = false;
			this.buttonNoAcc.Click += new System.EventHandler(this.buttonNoAcc_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(521, 219);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(134, 20);
			this.label1.TabIndex = 6;
			this.label1.Text = "Номер паспорта";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.label2.Location = new System.Drawing.Point(550, 303);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 20);
			this.label2.TabIndex = 7;
			this.label2.Text = "Пароль";
			// 
			// checkBoxPasswordShow
			// 
			this.checkBoxPasswordShow.AutoSize = true;
			this.checkBoxPasswordShow.Location = new System.Drawing.Point(735, 331);
			this.checkBoxPasswordShow.Name = "checkBoxPasswordShow";
			this.checkBoxPasswordShow.Size = new System.Drawing.Size(167, 24);
			this.checkBoxPasswordShow.TabIndex = 18;
			this.checkBoxPasswordShow.Text = "Показать пароль";
			this.checkBoxPasswordShow.UseVisualStyleBackColor = true;
			this.checkBoxPasswordShow.CheckedChanged += new System.EventHandler(this.checkBoxPasswordShow_CheckedChanged);
			// 
			// LoginMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1199, 725);
			this.Controls.Add(this.checkBoxPasswordShow);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonNoAcc);
			this.Controls.Add(this.tbPasspNum2);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.tbPasspNum1);
			this.Controls.Add(this.buttonConnect);
			this.Name = "LoginMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Мой Госпиталь";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginMenu_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginMenu_FormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonConnect;
		private System.Windows.Forms.TextBox tbPasspNum1;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.TextBox tbPasspNum2;
		private System.Windows.Forms.Button buttonNoAcc;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox checkBoxPasswordShow;
	}
}

