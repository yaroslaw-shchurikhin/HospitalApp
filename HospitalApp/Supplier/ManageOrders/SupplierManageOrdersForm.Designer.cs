namespace HospitalApp
{
	partial class SupplierManageOrdersForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierManageOrdersForm));
			this.buttonOrdersArchive = new System.Windows.Forms.Button();
			this.buttonOrdersConfirmed = new System.Windows.Forms.Button();
			this.buttonNewOrders = new System.Windows.Forms.Button();
			this.buttonBack = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonOrdersArchive
			// 
			this.buttonOrdersArchive.Location = new System.Drawing.Point(479, 426);
			this.buttonOrdersArchive.Name = "buttonOrdersArchive";
			this.buttonOrdersArchive.Size = new System.Drawing.Size(215, 96);
			this.buttonOrdersArchive.TabIndex = 0;
			this.buttonOrdersArchive.Text = "Архив Заказов";
			this.buttonOrdersArchive.UseVisualStyleBackColor = true;
			this.buttonOrdersArchive.Click += new System.EventHandler(this.buttonOrdersArchive_Click);
			// 
			// buttonOrdersConfirmed
			// 
			this.buttonOrdersConfirmed.Location = new System.Drawing.Point(479, 303);
			this.buttonOrdersConfirmed.Name = "buttonOrdersConfirmed";
			this.buttonOrdersConfirmed.Size = new System.Drawing.Size(215, 96);
			this.buttonOrdersConfirmed.TabIndex = 1;
			this.buttonOrdersConfirmed.Text = "Выполняющиеся заказы";
			this.buttonOrdersConfirmed.UseVisualStyleBackColor = true;
			this.buttonOrdersConfirmed.Click += new System.EventHandler(this.buttonOrdersConfirmed_Click);
			// 
			// buttonNewOrders
			// 
			this.buttonNewOrders.Location = new System.Drawing.Point(479, 176);
			this.buttonNewOrders.Name = "buttonNewOrders";
			this.buttonNewOrders.Size = new System.Drawing.Size(215, 96);
			this.buttonNewOrders.TabIndex = 2;
			this.buttonNewOrders.Text = "Новые заказы";
			this.buttonNewOrders.UseVisualStyleBackColor = true;
			this.buttonNewOrders.Click += new System.EventHandler(this.buttonNewOrders_Click);
			// 
			// buttonBack
			// 
			this.buttonBack.Location = new System.Drawing.Point(22, 24);
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.Size = new System.Drawing.Size(75, 65);
			this.buttonBack.TabIndex = 3;
			this.buttonBack.Text = "Назад";
			this.buttonBack.UseVisualStyleBackColor = true;
			this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
			// 
			// SupplierManageOrdersForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1199, 725);
			this.Controls.Add(this.buttonBack);
			this.Controls.Add(this.buttonNewOrders);
			this.Controls.Add(this.buttonOrdersConfirmed);
			this.Controls.Add(this.buttonOrdersArchive);
			this.DoubleBuffered = true;
			this.Name = "SupplierManageOrdersForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Управление заказами";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonOrdersArchive;
		private System.Windows.Forms.Button buttonOrdersConfirmed;
		private System.Windows.Forms.Button buttonNewOrders;
		private System.Windows.Forms.Button buttonBack;
	}
}