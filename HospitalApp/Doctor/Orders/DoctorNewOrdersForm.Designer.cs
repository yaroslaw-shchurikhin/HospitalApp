namespace HospitalApp.Doctor.Orders
{
	partial class DoctorNewOrdersForm
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
			this.dgDoctorOrders = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgDoctorOrders)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonBack
			// 
			this.buttonBack.Location = new System.Drawing.Point(1022, 628);
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.Size = new System.Drawing.Size(141, 64);
			this.buttonBack.TabIndex = 7;
			this.buttonBack.Text = "Назад";
			this.buttonBack.UseVisualStyleBackColor = true;
			this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
			// 
			// dgDoctorOrders
			// 
			this.dgDoctorOrders.BackgroundColor = System.Drawing.Color.Azure;
			this.dgDoctorOrders.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgDoctorOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgDoctorOrders.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgDoctorOrders.Location = new System.Drawing.Point(0, 0);
			this.dgDoctorOrders.Name = "dgDoctorOrders";
			this.dgDoctorOrders.ReadOnly = true;
			this.dgDoctorOrders.RowHeadersWidth = 62;
			this.dgDoctorOrders.RowTemplate.Height = 28;
			this.dgDoctorOrders.Size = new System.Drawing.Size(1199, 725);
			this.dgDoctorOrders.TabIndex = 6;
			this.dgDoctorOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDoctorOrders_CellClick);
			// 
			// DoctorNewOrdersForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1199, 725);
			this.Controls.Add(this.buttonBack);
			this.Controls.Add(this.dgDoctorOrders);
			this.Name = "DoctorNewOrdersForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Новые приёмы";
			((System.ComponentModel.ISupportInitialize)(this.dgDoctorOrders)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonBack;
		private System.Windows.Forms.DataGridView dgDoctorOrders;
	}
}