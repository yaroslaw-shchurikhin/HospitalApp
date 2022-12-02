namespace HospitalApp
{
	partial class AdminForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
			this.buttonOrders = new System.Windows.Forms.Button();
			this.buttonExit = new System.Windows.Forms.Button();
			this.buttonChangePassword = new System.Windows.Forms.Button();
			this.buttonSupplierOrders = new System.Windows.Forms.Button();
			this.buttonManageEmployees = new System.Windows.Forms.Button();
			this.buttonIncomeExpenses = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonOrders
			// 
			this.buttonOrders.Location = new System.Drawing.Point(431, 272);
			this.buttonOrders.Name = "buttonOrders";
			this.buttonOrders.Size = new System.Drawing.Size(326, 60);
			this.buttonOrders.TabIndex = 12;
			this.buttonOrders.Text = "Мои приёмы";
			this.buttonOrders.UseVisualStyleBackColor = true;
			this.buttonOrders.Click += new System.EventHandler(this.buttonOrders_Click);
			// 
			// buttonExit
			// 
			this.buttonExit.Location = new System.Drawing.Point(431, 638);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(326, 60);
			this.buttonExit.TabIndex = 11;
			this.buttonExit.Text = "Выход";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// buttonChangePassword
			// 
			this.buttonChangePassword.Location = new System.Drawing.Point(431, 354);
			this.buttonChangePassword.Name = "buttonChangePassword";
			this.buttonChangePassword.Size = new System.Drawing.Size(326, 60);
			this.buttonChangePassword.TabIndex = 10;
			this.buttonChangePassword.Text = "Изменить личные данные";
			this.buttonChangePassword.UseVisualStyleBackColor = true;
			this.buttonChangePassword.Click += new System.EventHandler(this.buttonChangePassword_Click);
			// 
			// buttonSupplierOrders
			// 
			this.buttonSupplierOrders.Location = new System.Drawing.Point(431, 190);
			this.buttonSupplierOrders.Name = "buttonSupplierOrders";
			this.buttonSupplierOrders.Size = new System.Drawing.Size(326, 60);
			this.buttonSupplierOrders.TabIndex = 13;
			this.buttonSupplierOrders.TabStop = false;
			this.buttonSupplierOrders.Text = "Работа с поставщиками";
			this.buttonSupplierOrders.UseVisualStyleBackColor = true;
			this.buttonSupplierOrders.Click += new System.EventHandler(this.buttonSupplierOrders_Click);
			// 
			// buttonManageEmployees
			// 
			this.buttonManageEmployees.Location = new System.Drawing.Point(431, 113);
			this.buttonManageEmployees.Name = "buttonManageEmployees";
			this.buttonManageEmployees.Size = new System.Drawing.Size(326, 60);
			this.buttonManageEmployees.TabIndex = 14;
			this.buttonManageEmployees.Text = "Управление персоналом";
			this.buttonManageEmployees.UseVisualStyleBackColor = true;
			this.buttonManageEmployees.Click += new System.EventHandler(this.buttonManageEmployees_Click);
			// 
			// buttonIncomeExpenses
			// 
			this.buttonIncomeExpenses.Location = new System.Drawing.Point(431, 37);
			this.buttonIncomeExpenses.Name = "buttonIncomeExpenses";
			this.buttonIncomeExpenses.Size = new System.Drawing.Size(326, 60);
			this.buttonIncomeExpenses.TabIndex = 15;
			this.buttonIncomeExpenses.Text = "Управление бюджетом";
			this.buttonIncomeExpenses.UseVisualStyleBackColor = true;
			this.buttonIncomeExpenses.Click += new System.EventHandler(this.buttonIncomeExpenses_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(431, 434);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(326, 60);
			this.button2.TabIndex = 17;
			this.button2.Text = "Сменить пароль";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// AdminForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1199, 725);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.buttonIncomeExpenses);
			this.Controls.Add(this.buttonManageEmployees);
			this.Controls.Add(this.buttonSupplierOrders);
			this.Controls.Add(this.buttonOrders);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.buttonChangePassword);
			this.DoubleBuffered = true;
			this.Name = "AdminForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Главврач";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonOrders;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.Button buttonChangePassword;
		private System.Windows.Forms.Button buttonSupplierOrders;
		private System.Windows.Forms.Button buttonManageEmployees;
		private System.Windows.Forms.Button buttonIncomeExpenses;
		private System.Windows.Forms.Button button2;
	}
}