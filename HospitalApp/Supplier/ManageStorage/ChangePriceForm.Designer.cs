namespace HospitalApp.Supplier.ManageStorage
{
	partial class ChangePriceForm
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
			this.tbPrice.Location = new System.Drawing.Point(143, 62);
			this.tbPrice.MaxLength = 5;
			this.tbPrice.Name = "tbPrice";
			this.tbPrice.Size = new System.Drawing.Size(113, 26);
			this.tbPrice.TabIndex = 5;
			// 
			// labelPrice
			// 
			this.labelPrice.AutoSize = true;
			this.labelPrice.Location = new System.Drawing.Point(51, 25);
			this.labelPrice.Name = "labelPrice";
			this.labelPrice.Size = new System.Drawing.Size(310, 20);
			this.labelPrice.TabIndex = 4;
			this.labelPrice.Text = "Введите новую цену за единицу товара";
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new System.Drawing.Point(95, 135);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(214, 54);
			this.buttonOK.TabIndex = 3;
			this.buttonOK.Text = "Подтвердить";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// ChangePriceForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(414, 218);
			this.Controls.Add(this.tbPrice);
			this.Controls.Add(this.labelPrice);
			this.Controls.Add(this.buttonOK);
			this.Name = "ChangePriceForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Изменение цены";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbPrice;
		private System.Windows.Forms.Label labelPrice;
		private System.Windows.Forms.Button buttonOK;
	}
}