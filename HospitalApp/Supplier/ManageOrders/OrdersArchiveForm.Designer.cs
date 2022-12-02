namespace HospitalApp.Supplier.ManageOrders
{
	partial class OrdersArchiveForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersArchiveForm));
			this.dgArchiveOrders = new System.Windows.Forms.DataGridView();
			this.buttonBack = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgArchiveOrders)).BeginInit();
			this.SuspendLayout();
			// 
			// dgArchiveOrders
			// 
			this.dgArchiveOrders.BackgroundColor = System.Drawing.Color.Azure;
			this.dgArchiveOrders.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgArchiveOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgArchiveOrders.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgArchiveOrders.Location = new System.Drawing.Point(0, 0);
			this.dgArchiveOrders.Name = "dgArchiveOrders";
			this.dgArchiveOrders.ReadOnly = true;
			this.dgArchiveOrders.RowHeadersWidth = 62;
			this.dgArchiveOrders.RowTemplate.Height = 28;
			this.dgArchiveOrders.Size = new System.Drawing.Size(1199, 725);
			this.dgArchiveOrders.TabIndex = 0;
			this.dgArchiveOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgArchiveOrders_CellClick);
			// 
			// buttonBack
			// 
			this.buttonBack.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.buttonBack.Location = new System.Drawing.Point(853, 222);
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.Size = new System.Drawing.Size(204, 291);
			this.buttonBack.TabIndex = 1;
			this.buttonBack.Text = "Назад";
			this.buttonBack.UseVisualStyleBackColor = false;
			this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
			// 
			// OrdersArchiveForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1199, 725);
			this.Controls.Add(this.buttonBack);
			this.Controls.Add(this.dgArchiveOrders);
			this.DoubleBuffered = true;
			this.Name = "OrdersArchiveForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Архив заказов";
			((System.ComponentModel.ISupportInitialize)(this.dgArchiveOrders)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgArchiveOrders;
		private System.Windows.Forms.Button buttonBack;
	}
}