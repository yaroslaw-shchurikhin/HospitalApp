namespace HospitalApp.Supplier.ManageOrders
{
	partial class AddInfoOrders
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
			this.dgAddInfoOrder = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgAddInfoOrder)).BeginInit();
			this.SuspendLayout();
			// 
			// dgAddInfoOrder
			// 
			this.dgAddInfoOrder.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgAddInfoOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgAddInfoOrder.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgAddInfoOrder.Location = new System.Drawing.Point(0, 0);
			this.dgAddInfoOrder.Name = "dgAddInfoOrder";
			this.dgAddInfoOrder.RowHeadersWidth = 62;
			this.dgAddInfoOrder.RowTemplate.Height = 28;
			this.dgAddInfoOrder.Size = new System.Drawing.Size(800, 450);
			this.dgAddInfoOrder.TabIndex = 0;
			// 
			// AddInfoOrders
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dgAddInfoOrder);
			this.Name = "AddInfoOrders";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Дополнительная информация";
			((System.ComponentModel.ISupportInitialize)(this.dgAddInfoOrder)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgAddInfoOrder;
	}
}