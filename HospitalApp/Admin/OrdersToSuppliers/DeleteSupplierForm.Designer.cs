namespace HospitalApp.Admin.OrdersToSuppliers
{
	partial class DeleteSupplierForm
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
			this.cbSupName = new System.Windows.Forms.ComboBox();
			this.labelName = new System.Windows.Forms.Label();
			this.buttonOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cbSupName
			// 
			this.cbSupName.FormattingEnabled = true;
			this.cbSupName.Location = new System.Drawing.Point(192, 83);
			this.cbSupName.Name = "cbSupName";
			this.cbSupName.Size = new System.Drawing.Size(201, 28);
			this.cbSupName.TabIndex = 0;
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(104, 38);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(406, 20);
			this.labelName.TabIndex = 1;
			this.labelName.Text = "Выберите поставщика, которого вы хотите удалить";
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new System.Drawing.Point(183, 193);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(221, 76);
			this.buttonOK.TabIndex = 2;
			this.buttonOK.Text = "Подтвердить";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// DeleteSupplierForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(608, 313);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.cbSupName);
			this.Name = "DeleteSupplierForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Удаление поставщика";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbSupName;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Button buttonOK;
	}
}