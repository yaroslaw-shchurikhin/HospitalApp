namespace HospitalApp.Admin.OrdersToSuppliers
{
	partial class OrdersListForm
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
			this.buttonBack = new System.Windows.Forms.Button();
			this.dgConfirmedOrders = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgConfirmedOrders)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonBack
			// 
			this.buttonBack.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.buttonBack.Location = new System.Drawing.Point(853, 222);
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.Size = new System.Drawing.Size(204, 291);
			this.buttonBack.TabIndex = 4;
			this.buttonBack.Text = "Назад";
			this.buttonBack.UseVisualStyleBackColor = false;
			this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
			// 
			// dgConfirmedOrders
			// 
			this.dgConfirmedOrders.BackgroundColor = System.Drawing.Color.Azure;
			this.dgConfirmedOrders.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgConfirmedOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgConfirmedOrders.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgConfirmedOrders.Location = new System.Drawing.Point(0, 0);
			this.dgConfirmedOrders.Name = "dgConfirmedOrders";
			this.dgConfirmedOrders.ReadOnly = true;
			this.dgConfirmedOrders.RowHeadersWidth = 62;
			this.dgConfirmedOrders.RowTemplate.Height = 28;
			this.dgConfirmedOrders.Size = new System.Drawing.Size(1199, 725);
			this.dgConfirmedOrders.TabIndex = 3;
			this.dgConfirmedOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgConfirmedOrders_CellClick);
			// 
			// OrdersListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1199, 725);
			this.Controls.Add(this.buttonBack);
			this.Controls.Add(this.dgConfirmedOrders);
			this.Name = "OrdersListForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Список заказов";
			((System.ComponentModel.ISupportInitialize)(this.dgConfirmedOrders)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonBack;
		private System.Windows.Forms.DataGridView dgConfirmedOrders;
	}
}