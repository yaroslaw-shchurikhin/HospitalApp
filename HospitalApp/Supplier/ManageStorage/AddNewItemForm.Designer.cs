namespace HospitalApp.Supplier.ManageStorage
{
	partial class AddNewItemForm
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
			this.buttonOK = new System.Windows.Forms.Button();
			this.cbNames = new System.Windows.Forms.ComboBox();
			this.tbCount = new System.Windows.Forms.TextBox();
			this.tbPrice = new System.Windows.Forms.TextBox();
			this.labelName = new System.Windows.Forms.Label();
			this.labelCount = new System.Windows.Forms.Label();
			this.labelPrice = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new System.Drawing.Point(280, 336);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(206, 80);
			this.buttonOK.TabIndex = 0;
			this.buttonOK.Text = "Добавить";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// cbNames
			// 
			this.cbNames.FormattingEnabled = true;
			this.cbNames.Location = new System.Drawing.Point(159, 184);
			this.cbNames.Name = "cbNames";
			this.cbNames.Size = new System.Drawing.Size(137, 28);
			this.cbNames.TabIndex = 1;
			// 
			// tbCount
			// 
			this.tbCount.Location = new System.Drawing.Point(355, 185);
			this.tbCount.MaxLength = 5;
			this.tbCount.Name = "tbCount";
			this.tbCount.Size = new System.Drawing.Size(100, 26);
			this.tbCount.TabIndex = 2;
			this.tbCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCount_KeyPress);
			// 
			// tbPrice
			// 
			this.tbPrice.Location = new System.Drawing.Point(519, 185);
			this.tbPrice.MaxLength = 5;
			this.tbPrice.Name = "tbPrice";
			this.tbPrice.Size = new System.Drawing.Size(100, 26);
			this.tbPrice.TabIndex = 3;
			this.tbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrice_KeyPress);
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(155, 151);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(141, 20);
			this.labelName.TabIndex = 4;
			this.labelName.Text = "Название товара";
			// 
			// labelCount
			// 
			this.labelCount.AutoSize = true;
			this.labelCount.Location = new System.Drawing.Point(351, 151);
			this.labelCount.Name = "labelCount";
			this.labelCount.Size = new System.Drawing.Size(100, 20);
			this.labelCount.TabIndex = 5;
			this.labelCount.Text = "Количество";
			// 
			// labelPrice
			// 
			this.labelPrice.AutoSize = true;
			this.labelPrice.Location = new System.Drawing.Point(515, 151);
			this.labelPrice.Name = "labelPrice";
			this.labelPrice.Size = new System.Drawing.Size(136, 20);
			this.labelPrice.TabIndex = 6;
			this.labelPrice.Text = "Цена за единицу";
			// 
			// AddNewItemForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.labelPrice);
			this.Controls.Add(this.labelCount);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.tbPrice);
			this.Controls.Add(this.tbCount);
			this.Controls.Add(this.cbNames);
			this.Controls.Add(this.buttonOK);
			this.Name = "AddNewItemForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Добавление нового товара";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.ComboBox cbNames;
		private System.Windows.Forms.TextBox tbCount;
		private System.Windows.Forms.TextBox tbPrice;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelCount;
		private System.Windows.Forms.Label labelPrice;
	}
}