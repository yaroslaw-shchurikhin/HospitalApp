namespace HospitalApp.Admin.OrdersToSuppliers
{
	partial class MainOrdersForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainOrdersForm));
			this.buttonBack = new System.Windows.Forms.Button();
			this.buttonManageSuppliers = new System.Windows.Forms.Button();
			this.buttonOrders = new System.Windows.Forms.Button();
			this.buttonNewOrder = new System.Windows.Forms.Button();
			this.buttonAssortiment = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonBack
			// 
			this.buttonBack.Location = new System.Drawing.Point(13, 12);
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.Size = new System.Drawing.Size(75, 65);
			this.buttonBack.TabIndex = 11;
			this.buttonBack.Text = "Назад";
			this.buttonBack.UseVisualStyleBackColor = true;
			this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
			// 
			// buttonManageSuppliers
			// 
			this.buttonManageSuppliers.Location = new System.Drawing.Point(400, 465);
			this.buttonManageSuppliers.Name = "buttonManageSuppliers";
			this.buttonManageSuppliers.Size = new System.Drawing.Size(383, 83);
			this.buttonManageSuppliers.TabIndex = 10;
			this.buttonManageSuppliers.Text = "Управление поставщиками";
			this.buttonManageSuppliers.UseVisualStyleBackColor = true;
			this.buttonManageSuppliers.Click += new System.EventHandler(this.buttonManageSuppliers_Click);
			// 
			// buttonOrders
			// 
			this.buttonOrders.Location = new System.Drawing.Point(400, 350);
			this.buttonOrders.Name = "buttonOrders";
			this.buttonOrders.Size = new System.Drawing.Size(383, 83);
			this.buttonOrders.TabIndex = 9;
			this.buttonOrders.Text = "Заказы";
			this.buttonOrders.UseVisualStyleBackColor = true;
			this.buttonOrders.Click += new System.EventHandler(this.buttonOrders_Click);
			// 
			// buttonNewOrder
			// 
			this.buttonNewOrder.Location = new System.Drawing.Point(400, 117);
			this.buttonNewOrder.Name = "buttonNewOrder";
			this.buttonNewOrder.Size = new System.Drawing.Size(383, 83);
			this.buttonNewOrder.TabIndex = 12;
			this.buttonNewOrder.Text = "Создать новый заказ";
			this.buttonNewOrder.UseVisualStyleBackColor = true;
			this.buttonNewOrder.Click += new System.EventHandler(this.buttonNewOrder_Click);
			// 
			// buttonAssortiment
			// 
			this.buttonAssortiment.Location = new System.Drawing.Point(400, 232);
			this.buttonAssortiment.Name = "buttonAssortiment";
			this.buttonAssortiment.Size = new System.Drawing.Size(383, 83);
			this.buttonAssortiment.TabIndex = 13;
			this.buttonAssortiment.Text = "Просмотр ассортимента";
			this.buttonAssortiment.UseVisualStyleBackColor = true;
			this.buttonAssortiment.Click += new System.EventHandler(this.buttonAssortiment_Click);
			// 
			// MainOrdersForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1199, 725);
			this.Controls.Add(this.buttonAssortiment);
			this.Controls.Add(this.buttonNewOrder);
			this.Controls.Add(this.buttonBack);
			this.Controls.Add(this.buttonManageSuppliers);
			this.Controls.Add(this.buttonOrders);
			this.DoubleBuffered = true;
			this.Name = "MainOrdersForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Управление заказами";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonBack;
		private System.Windows.Forms.Button buttonManageSuppliers;
		private System.Windows.Forms.Button buttonOrders;
		private System.Windows.Forms.Button buttonNewOrder;
		private System.Windows.Forms.Button buttonAssortiment;
	}
}