namespace HospitalApp
{
	partial class SupplierForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierForm));
			this.buttonOrders = new System.Windows.Forms.Button();
			this.buttonStorage = new System.Windows.Forms.Button();
			this.buttonChangePassword = new System.Windows.Forms.Button();
			this.buttonExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonOrders
			// 
			this.buttonOrders.Location = new System.Drawing.Point(505, 151);
			this.buttonOrders.Name = "buttonOrders";
			this.buttonOrders.Size = new System.Drawing.Size(158, 70);
			this.buttonOrders.TabIndex = 0;
			this.buttonOrders.Text = "Управление заказами";
			this.buttonOrders.UseVisualStyleBackColor = true;
			this.buttonOrders.Click += new System.EventHandler(this.buttonOrders_Click);
			// 
			// buttonStorage
			// 
			this.buttonStorage.Location = new System.Drawing.Point(505, 256);
			this.buttonStorage.Name = "buttonStorage";
			this.buttonStorage.Size = new System.Drawing.Size(158, 70);
			this.buttonStorage.TabIndex = 1;
			this.buttonStorage.Text = "Управление складом";
			this.buttonStorage.UseVisualStyleBackColor = true;
			this.buttonStorage.Click += new System.EventHandler(this.buttonStorage_Click);
			// 
			// buttonChangePassword
			// 
			this.buttonChangePassword.Location = new System.Drawing.Point(505, 361);
			this.buttonChangePassword.Name = "buttonChangePassword";
			this.buttonChangePassword.Size = new System.Drawing.Size(158, 70);
			this.buttonChangePassword.TabIndex = 2;
			this.buttonChangePassword.Text = "Сменить пароль";
			this.buttonChangePassword.UseVisualStyleBackColor = true;
			this.buttonChangePassword.Click += new System.EventHandler(this.buttonChangePassword_Click);
			// 
			// buttonExit
			// 
			this.buttonExit.Location = new System.Drawing.Point(505, 468);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(158, 70);
			this.buttonExit.TabIndex = 3;
			this.buttonExit.Text = "Выход";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// SupplierForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1199, 725);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.buttonChangePassword);
			this.Controls.Add(this.buttonStorage);
			this.Controls.Add(this.buttonOrders);
			this.DoubleBuffered = true;
			this.Name = "SupplierForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Поставщик";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SupplierForm_FormClosing);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonOrders;
		private System.Windows.Forms.Button buttonStorage;
		private System.Windows.Forms.Button buttonChangePassword;
		private System.Windows.Forms.Button buttonExit;
	}
}