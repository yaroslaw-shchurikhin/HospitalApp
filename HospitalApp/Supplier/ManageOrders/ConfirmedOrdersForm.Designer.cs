namespace HospitalApp.Supplier.ManageOrders
{
	partial class ConfirmedOrdersForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmedOrdersForm));
			this.dgConfirmedOrders = new System.Windows.Forms.DataGridView();
			this.buttonBack = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgConfirmedOrders)).BeginInit();
			this.SuspendLayout();
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
			this.dgConfirmedOrders.TabIndex = 1;
			this.dgConfirmedOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgConfirmedOrders_CellClick);
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
			// ConfirmedOrdersForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1199, 725);
			this.Controls.Add(this.buttonBack);
			this.Controls.Add(this.dgConfirmedOrders);
			this.DoubleBuffered = true;
			this.Name = "ConfirmedOrdersForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Подтверждённые заказы";
			((System.ComponentModel.ISupportInitialize)(this.dgConfirmedOrders)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgConfirmedOrders;
		private System.Windows.Forms.Button buttonBack;
	}
}