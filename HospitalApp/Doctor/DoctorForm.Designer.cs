namespace HospitalApp
{
	partial class DoctorForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorForm));
			this.buttonOrders = new System.Windows.Forms.Button();
			this.buttonExit = new System.Windows.Forms.Button();
			this.buttonChangePassword = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonOrders
			// 
			this.buttonOrders.Location = new System.Drawing.Point(514, 208);
			this.buttonOrders.Name = "buttonOrders";
			this.buttonOrders.Size = new System.Drawing.Size(158, 70);
			this.buttonOrders.TabIndex = 9;
			this.buttonOrders.Text = "Мои приёмы";
			this.buttonOrders.UseVisualStyleBackColor = true;
			this.buttonOrders.Click += new System.EventHandler(this.buttonOrders_Click);
			// 
			// buttonExit
			// 
			this.buttonExit.Location = new System.Drawing.Point(514, 502);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(158, 70);
			this.buttonExit.TabIndex = 8;
			this.buttonExit.Text = "Выход";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// buttonChangePassword
			// 
			this.buttonChangePassword.Location = new System.Drawing.Point(514, 310);
			this.buttonChangePassword.Name = "buttonChangePassword";
			this.buttonChangePassword.Size = new System.Drawing.Size(158, 70);
			this.buttonChangePassword.TabIndex = 7;
			this.buttonChangePassword.Text = "Изменить личные данные";
			this.buttonChangePassword.UseVisualStyleBackColor = true;
			this.buttonChangePassword.Click += new System.EventHandler(this.buttonChangePassword_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(514, 409);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(158, 70);
			this.button1.TabIndex = 10;
			this.button1.Text = "Сменить пароль";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// DoctorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1199, 725);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.buttonOrders);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.buttonChangePassword);
			this.DoubleBuffered = true;
			this.Name = "DoctorForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Врач";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DoctorForm_FormClosing);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonOrders;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.Button buttonChangePassword;
		private System.Windows.Forms.Button button1;
	}
}