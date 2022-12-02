namespace HospitalApp
{
	partial class ChangePasswordForm
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
			this.labelPassword = new System.Windows.Forms.Label();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.buttonOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelPassword
			// 
			this.labelPassword.AutoSize = true;
			this.labelPassword.Location = new System.Drawing.Point(189, 58);
			this.labelPassword.Name = "labelPassword";
			this.labelPassword.Size = new System.Drawing.Size(186, 20);
			this.labelPassword.TabIndex = 0;
			this.labelPassword.Text = "Введите новый пароль";
			// 
			// tbPassword
			// 
			this.tbPassword.Location = new System.Drawing.Point(193, 96);
			this.tbPassword.MaxLength = 20;
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.Size = new System.Drawing.Size(182, 26);
			this.tbPassword.TabIndex = 1;
			this.tbPassword.UseSystemPasswordChar = true;
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new System.Drawing.Point(170, 191);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(223, 64);
			this.buttonOK.TabIndex = 2;
			this.buttonOK.Text = "Подтвердить";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// ChangePasswordForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(575, 282);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.labelPassword);
			this.Name = "ChangePasswordForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Изменение пароля";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelPassword;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.Button buttonOK;
	}
}