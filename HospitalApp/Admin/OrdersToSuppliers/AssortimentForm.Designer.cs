namespace HospitalApp.Admin.OrdersToSuppliers
{
	partial class AssortimentForm
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
			this.dgAssortiment = new System.Windows.Forms.DataGridView();
			this.buttonBack = new System.Windows.Forms.Button();
			this.cbName = new System.Windows.Forms.ComboBox();
			this.labelName = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgAssortiment)).BeginInit();
			this.SuspendLayout();
			// 
			// dgAssortiment
			// 
			this.dgAssortiment.BackgroundColor = System.Drawing.Color.Azure;
			this.dgAssortiment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgAssortiment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgAssortiment.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dgAssortiment.Location = new System.Drawing.Point(0, 178);
			this.dgAssortiment.Name = "dgAssortiment";
			this.dgAssortiment.ReadOnly = true;
			this.dgAssortiment.RowHeadersWidth = 62;
			this.dgAssortiment.RowTemplate.Height = 28;
			this.dgAssortiment.Size = new System.Drawing.Size(1199, 547);
			this.dgAssortiment.TabIndex = 2;
			// 
			// buttonBack
			// 
			this.buttonBack.Location = new System.Drawing.Point(13, 13);
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.Size = new System.Drawing.Size(75, 68);
			this.buttonBack.TabIndex = 3;
			this.buttonBack.TabStop = false;
			this.buttonBack.Text = "Назад";
			this.buttonBack.UseVisualStyleBackColor = true;
			this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
			// 
			// cbName
			// 
			this.cbName.FormattingEnabled = true;
			this.cbName.Location = new System.Drawing.Point(468, 93);
			this.cbName.Name = "cbName";
			this.cbName.Size = new System.Drawing.Size(230, 28);
			this.cbName.TabIndex = 4;
			this.cbName.SelectedIndexChanged += new System.EventHandler(this.cbName_SelectedIndexChanged);
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(464, 61);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(181, 20);
			this.labelName.TabIndex = 5;
			this.labelName.Text = "Выберите поставщика";
			// 
			// AssortimentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1199, 725);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.cbName);
			this.Controls.Add(this.buttonBack);
			this.Controls.Add(this.dgAssortiment);
			this.Name = "AssortimentForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ассортимент";
			((System.ComponentModel.ISupportInitialize)(this.dgAssortiment)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgAssortiment;
		private System.Windows.Forms.Button buttonBack;
		private System.Windows.Forms.ComboBox cbName;
		private System.Windows.Forms.Label labelName;
	}
}