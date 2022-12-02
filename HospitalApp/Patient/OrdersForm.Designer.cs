namespace HospitalApp.Patient
{
	partial class OrdersForm
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
			this.dgPatientOrders = new System.Windows.Forms.DataGridView();
			this.buttonBack = new System.Windows.Forms.Button();
			this.buttonAddOrder = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgPatientOrders)).BeginInit();
			this.SuspendLayout();
			// 
			// dgPatientOrders
			// 
			this.dgPatientOrders.BackgroundColor = System.Drawing.Color.Azure;
			this.dgPatientOrders.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgPatientOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgPatientOrders.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgPatientOrders.Location = new System.Drawing.Point(0, 0);
			this.dgPatientOrders.Name = "dgPatientOrders";
			this.dgPatientOrders.ReadOnly = true;
			this.dgPatientOrders.RowHeadersWidth = 62;
			this.dgPatientOrders.RowTemplate.Height = 28;
			this.dgPatientOrders.Size = new System.Drawing.Size(1199, 725);
			this.dgPatientOrders.TabIndex = 2;
			this.dgPatientOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPatientOrders_CellClick);
			this.dgPatientOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPatientOrders_CellContentClick);
			// 
			// buttonBack
			// 
			this.buttonBack.Location = new System.Drawing.Point(1022, 628);
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.Size = new System.Drawing.Size(141, 64);
			this.buttonBack.TabIndex = 3;
			this.buttonBack.Text = "Назад";
			this.buttonBack.UseVisualStyleBackColor = true;
			this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
			// 
			// buttonAddOrder
			// 
			this.buttonAddOrder.Location = new System.Drawing.Point(974, 297);
			this.buttonAddOrder.Name = "buttonAddOrder";
			this.buttonAddOrder.Size = new System.Drawing.Size(189, 85);
			this.buttonAddOrder.TabIndex = 4;
			this.buttonAddOrder.Text = "Записаться на приём";
			this.buttonAddOrder.UseVisualStyleBackColor = true;
			this.buttonAddOrder.Click += new System.EventHandler(this.buttonAddOrder_Click);
			// 
			// OrdersForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1199, 725);
			this.Controls.Add(this.buttonAddOrder);
			this.Controls.Add(this.buttonBack);
			this.Controls.Add(this.dgPatientOrders);
			this.Name = "OrdersForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Заказы";
			((System.ComponentModel.ISupportInitialize)(this.dgPatientOrders)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgPatientOrders;
		private System.Windows.Forms.Button buttonBack;
		private System.Windows.Forms.Button buttonAddOrder;
	}
}