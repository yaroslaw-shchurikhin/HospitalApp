namespace HospitalApp.Doctor.Orders
{
	partial class OrderPrice
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
			this.tbPrice = new System.Windows.Forms.TextBox();
			this.labelPrice = new System.Windows.Forms.Label();
			this.buttonOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tbPrice
			// 
			this.tbPrice.Location = new System.Drawing.Point(127, 63);
			this.tbPrice.MaxLength = 5;
			this.tbPrice.Name = "tbPrice";
			this.tbPrice.Size = new System.Drawing.Size(100, 26);
			this.tbPrice.TabIndex = 0;
			this.tbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrice_KeyPress);
			// 
			// labelPrice
			// 
			this.labelPrice.AutoSize = true;
			this.labelPrice.Location = new System.Drawing.Point(73, 28);
			this.labelPrice.Name = "labelPrice";
			this.labelPrice.Size = new System.Drawing.Size(221, 20);
			this.labelPrice.TabIndex = 1;
			this.labelPrice.Text = "Введите стоимость приёма";
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new System.Drawing.Point(88, 120);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(186, 58);
			this.buttonOK.TabIndex = 2;
			this.buttonOK.Text = "Подтвердить";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// OrderPrice
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(390, 202);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.labelPrice);
			this.Controls.Add(this.tbPrice);
			this.Name = "OrderPrice";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Цена заказа";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbPrice;
		private System.Windows.Forms.Label labelPrice;
		private System.Windows.Forms.Button buttonOK;
	}
}