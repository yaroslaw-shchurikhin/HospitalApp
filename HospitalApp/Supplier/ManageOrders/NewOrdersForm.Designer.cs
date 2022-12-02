namespace HospitalApp.Supplier.ManageOrders
{
	partial class NewOrdersForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewOrdersForm));
			this.dgNewOrders = new System.Windows.Forms.DataGridView();
			this.buttonBack = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgNewOrders)).BeginInit();
			this.SuspendLayout();
			// 
			// dgNewOrders
			// 
			this.dgNewOrders.BackgroundColor = System.Drawing.Color.Azure;
			this.dgNewOrders.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgNewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgNewOrders.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgNewOrders.Location = new System.Drawing.Point(0, 0);
			this.dgNewOrders.Name = "dgNewOrders";
			this.dgNewOrders.ReadOnly = true;
			this.dgNewOrders.RowHeadersWidth = 62;
			this.dgNewOrders.RowTemplate.Height = 28;
			this.dgNewOrders.Size = new System.Drawing.Size(1199, 725);
			this.dgNewOrders.TabIndex = 1;
			this.dgNewOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgNewOrders_CellClick);
			// 
			// buttonBack
			// 
			this.buttonBack.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.buttonBack.Location = new System.Drawing.Point(853, 222);
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.Size = new System.Drawing.Size(204, 291);
			this.buttonBack.TabIndex = 2;
			this.buttonBack.Text = "Назад";
			this.buttonBack.UseVisualStyleBackColor = false;
			this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
			// 
			// NewOrdersForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1199, 725);
			this.Controls.Add(this.buttonBack);
			this.Controls.Add(this.dgNewOrders);
			this.DoubleBuffered = true;
			this.Name = "NewOrdersForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Новые заказы";
			((System.ComponentModel.ISupportInitialize)(this.dgNewOrders)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgNewOrders;
		private System.Windows.Forms.Button buttonBack;
	}
}