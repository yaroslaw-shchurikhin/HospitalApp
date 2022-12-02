namespace HospitalApp.Admin.OrdersToSuppliers
{
	partial class ChooseOrderSupForm
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
			this.labelName = new System.Windows.Forms.Label();
			this.cbSupName = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new System.Drawing.Point(171, 183);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(221, 76);
			this.buttonOK.TabIndex = 5;
			this.buttonOK.Text = "Подтвердить";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Visible = false;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(176, 40);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(181, 20);
			this.labelName.TabIndex = 4;
			this.labelName.Text = "Выберите поставщика";
			// 
			// cbSupName
			// 
			this.cbSupName.FormattingEnabled = true;
			this.cbSupName.Location = new System.Drawing.Point(180, 73);
			this.cbSupName.Name = "cbSupName";
			this.cbSupName.Size = new System.Drawing.Size(201, 28);
			this.cbSupName.TabIndex = 3;
			this.cbSupName.SelectedIndexChanged += new System.EventHandler(this.cbSupName_SelectedIndexChanged);
			// 
			// ChooseOrderSupForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(590, 287);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.cbSupName);
			this.Name = "ChooseOrderSupForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Выбор поставщика";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.ComboBox cbSupName;
	}
}