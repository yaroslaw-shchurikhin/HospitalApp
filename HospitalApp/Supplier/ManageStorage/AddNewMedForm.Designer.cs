namespace HospitalApp.Supplier.ManageStorage
{
	partial class AddNewMedForm
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
			this.labelMedName = new System.Windows.Forms.Label();
			this.cbMedName = new System.Windows.Forms.ComboBox();
			this.labelCount = new System.Windows.Forms.Label();
			this.tbCount = new System.Windows.Forms.TextBox();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelMedName
			// 
			this.labelMedName.AutoSize = true;
			this.labelMedName.Location = new System.Drawing.Point(230, 122);
			this.labelMedName.Name = "labelMedName";
			this.labelMedName.Size = new System.Drawing.Size(167, 20);
			this.labelMedName.TabIndex = 0;
			this.labelMedName.Text = "Название лекарства";
			// 
			// cbMedName
			// 
			this.cbMedName.FormattingEnabled = true;
			this.cbMedName.Location = new System.Drawing.Point(234, 155);
			this.cbMedName.Name = "cbMedName";
			this.cbMedName.Size = new System.Drawing.Size(163, 28);
			this.cbMedName.TabIndex = 1;
			// 
			// labelCount
			// 
			this.labelCount.AutoSize = true;
			this.labelCount.Location = new System.Drawing.Point(439, 122);
			this.labelCount.Name = "labelCount";
			this.labelCount.Size = new System.Drawing.Size(100, 20);
			this.labelCount.TabIndex = 2;
			this.labelCount.Text = "Количество";
			// 
			// tbCount
			// 
			this.tbCount.Location = new System.Drawing.Point(443, 156);
			this.tbCount.MaxLength = 4;
			this.tbCount.Name = "tbCount";
			this.tbCount.Size = new System.Drawing.Size(100, 26);
			this.tbCount.TabIndex = 3;
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(262, 257);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(264, 76);
			this.buttonAdd.TabIndex = 4;
			this.buttonAdd.Text = "Добавить";
			this.buttonAdd.UseVisualStyleBackColor = true;
			// 
			// AddNewMedForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.tbCount);
			this.Controls.Add(this.labelCount);
			this.Controls.Add(this.cbMedName);
			this.Controls.Add(this.labelMedName);
			this.Name = "AddNewMedForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Добавление товара";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelMedName;
		private System.Windows.Forms.ComboBox cbMedName;
		private System.Windows.Forms.Label labelCount;
		private System.Windows.Forms.TextBox tbCount;
		private System.Windows.Forms.Button buttonAdd;
	}
}