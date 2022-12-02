namespace HospitalApp
{
	partial class PatientForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientForm));
			this.buttonExit = new System.Windows.Forms.Button();
			this.buttonChangePassword = new System.Windows.Forms.Button();
			this.buttonOrders = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.labelDebt = new System.Windows.Forms.Label();
			this.labelDebtCount = new System.Windows.Forms.Label();
			this.buttonPay = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonExit
			// 
			this.buttonExit.Location = new System.Drawing.Point(515, 514);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(153, 78);
			this.buttonExit.TabIndex = 5;
			this.buttonExit.Text = "Выход";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// buttonChangePassword
			// 
			this.buttonChangePassword.Location = new System.Drawing.Point(515, 307);
			this.buttonChangePassword.Name = "buttonChangePassword";
			this.buttonChangePassword.Size = new System.Drawing.Size(153, 78);
			this.buttonChangePassword.TabIndex = 4;
			this.buttonChangePassword.Text = "Изменить личные данные";
			this.buttonChangePassword.UseVisualStyleBackColor = true;
			this.buttonChangePassword.Click += new System.EventHandler(this.buttonChangePassword_Click);
			// 
			// buttonOrders
			// 
			this.buttonOrders.Location = new System.Drawing.Point(515, 200);
			this.buttonOrders.Name = "buttonOrders";
			this.buttonOrders.Size = new System.Drawing.Size(153, 78);
			this.buttonOrders.TabIndex = 6;
			this.buttonOrders.Text = "Мои приёмы";
			this.buttonOrders.UseVisualStyleBackColor = true;
			this.buttonOrders.Click += new System.EventHandler(this.buttonOrders_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(515, 415);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(153, 70);
			this.button1.TabIndex = 7;
			this.button1.Text = "Сменить пароль";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// labelDebt
			// 
			this.labelDebt.AutoSize = true;
			this.labelDebt.Location = new System.Drawing.Point(893, 59);
			this.labelDebt.Name = "labelDebt";
			this.labelDebt.Size = new System.Drawing.Size(179, 20);
			this.labelDebt.TabIndex = 8;
			this.labelDebt.Text = "Ваша задолженность:";
			this.labelDebt.Visible = false;
			// 
			// labelDebtCount
			// 
			this.labelDebtCount.AutoSize = true;
			this.labelDebtCount.Location = new System.Drawing.Point(1079, 59);
			this.labelDebtCount.Name = "labelDebtCount";
			this.labelDebtCount.Size = new System.Drawing.Size(0, 20);
			this.labelDebtCount.TabIndex = 9;
			// 
			// buttonPay
			// 
			this.buttonPay.Location = new System.Drawing.Point(1039, 96);
			this.buttonPay.Name = "buttonPay";
			this.buttonPay.Size = new System.Drawing.Size(148, 42);
			this.buttonPay.TabIndex = 10;
			this.buttonPay.Text = "Оплатить";
			this.buttonPay.UseVisualStyleBackColor = true;
			this.buttonPay.Visible = false;
			this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
			// 
			// PatientForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1199, 725);
			this.Controls.Add(this.buttonPay);
			this.Controls.Add(this.labelDebtCount);
			this.Controls.Add(this.labelDebt);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.buttonOrders);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.buttonChangePassword);
			this.DoubleBuffered = true;
			this.Name = "PatientForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Пациент";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.Button buttonChangePassword;
		private System.Windows.Forms.Button buttonOrders;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label labelDebt;
		private System.Windows.Forms.Label labelDebtCount;
		private System.Windows.Forms.Button buttonPay;
	}
}