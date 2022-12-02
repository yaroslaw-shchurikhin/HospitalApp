namespace HospitalApp.Admin.OrdersToSuppliers
{
	partial class AddSupplierForm
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
			this.tbName = new System.Windows.Forms.TextBox();
			this.labelLogin = new System.Windows.Forms.Label();
			this.tbLogin = new System.Windows.Forms.TextBox();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.labelPassword = new System.Windows.Forms.Label();
			this.buttonOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(190, 18);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(160, 20);
			this.labelName.TabIndex = 0;
			this.labelName.Text = "Название компании";
			// 
			// tbName
			// 
			this.tbName.Location = new System.Drawing.Point(194, 54);
			this.tbName.MaxLength = 30;
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(156, 26);
			this.tbName.TabIndex = 1;
			// 
			// labelLogin
			// 
			this.labelLogin.AutoSize = true;
			this.labelLogin.Location = new System.Drawing.Point(190, 91);
			this.labelLogin.Name = "labelLogin";
			this.labelLogin.Size = new System.Drawing.Size(133, 20);
			this.labelLogin.TabIndex = 2;
			this.labelLogin.Text = "Логин (10 цифр)";
			// 
			// tbLogin
			// 
			this.tbLogin.Location = new System.Drawing.Point(194, 125);
			this.tbLogin.MaxLength = 10;
			this.tbLogin.Name = "tbLogin";
			this.tbLogin.Size = new System.Drawing.Size(152, 26);
			this.tbLogin.TabIndex = 3;
			this.tbLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLogin_KeyPress);
			// 
			// tbPassword
			// 
			this.tbPassword.Location = new System.Drawing.Point(190, 190);
			this.tbPassword.MaxLength = 20;
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.Size = new System.Drawing.Size(152, 26);
			this.tbPassword.TabIndex = 4;
			// 
			// labelPassword
			// 
			this.labelPassword.AutoSize = true;
			this.labelPassword.Location = new System.Drawing.Point(190, 164);
			this.labelPassword.Name = "labelPassword";
			this.labelPassword.Size = new System.Drawing.Size(67, 20);
			this.labelPassword.TabIndex = 5;
			this.labelPassword.Text = "Пароль";
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new System.Drawing.Point(164, 265);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(211, 51);
			this.buttonOK.TabIndex = 6;
			this.buttonOK.Text = "Подтвердить";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// AddSupplierForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(564, 341);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.labelPassword);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.tbLogin);
			this.Controls.Add(this.labelLogin);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.labelName);
			this.Name = "AddSupplierForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Добавление поставщика";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.Label labelLogin;
		private System.Windows.Forms.TextBox tbLogin;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.Label labelPassword;
		private System.Windows.Forms.Button buttonOK;
	}
}