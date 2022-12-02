namespace HospitalApp.Supplier.ManageStorage
{
	partial class ChangeCountForm
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
			this.labelCount = new System.Windows.Forms.Label();
			this.tbCount = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new System.Drawing.Point(102, 137);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(214, 54);
			this.buttonOK.TabIndex = 0;
			this.buttonOK.Text = "Подтвердить";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// labelCount
			// 
			this.labelCount.AutoSize = true;
			this.labelCount.Location = new System.Drawing.Point(75, 30);
			this.labelCount.Name = "labelCount";
			this.labelCount.Size = new System.Drawing.Size(281, 20);
			this.labelCount.TabIndex = 1;
			this.labelCount.Text = "Сколько штук вы хотите добавить?";
			// 
			// tbCount
			// 
			this.tbCount.Location = new System.Drawing.Point(150, 64);
			this.tbCount.Name = "tbCount";
			this.tbCount.Size = new System.Drawing.Size(113, 26);
			this.tbCount.TabIndex = 2;
			// 
			// ChangeCountForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(414, 218);
			this.Controls.Add(this.tbCount);
			this.Controls.Add(this.labelCount);
			this.Controls.Add(this.buttonOK);
			this.Name = "ChangeCountForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Изменение количества товара";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Label labelCount;
		private System.Windows.Forms.TextBox tbCount;
	}
}