namespace HospitalApp.Doctor.Orders
{
	partial class PrescribeMedicineForm
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
			this.cbMedName = new System.Windows.Forms.ComboBox();
			this.labelMedName = new System.Windows.Forms.Label();
			this.labelCount = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.cbCount = new System.Windows.Forms.ComboBox();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.dgOD = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgOD)).BeginInit();
			this.SuspendLayout();
			// 
			// cbMedName
			// 
			this.cbMedName.FormattingEnabled = true;
			this.cbMedName.Location = new System.Drawing.Point(12, 36);
			this.cbMedName.Name = "cbMedName";
			this.cbMedName.Size = new System.Drawing.Size(168, 28);
			this.cbMedName.TabIndex = 0;
			this.cbMedName.SelectedIndexChanged += new System.EventHandler(this.cbMedName_SelectedIndexChanged);
			// 
			// labelMedName
			// 
			this.labelMedName.AutoSize = true;
			this.labelMedName.Location = new System.Drawing.Point(12, 10);
			this.labelMedName.Name = "labelMedName";
			this.labelMedName.Size = new System.Drawing.Size(168, 20);
			this.labelMedName.TabIndex = 1;
			this.labelMedName.Text = "Название препарата";
			// 
			// labelCount
			// 
			this.labelCount.AutoSize = true;
			this.labelCount.Location = new System.Drawing.Point(12, 93);
			this.labelCount.Name = "labelCount";
			this.labelCount.Size = new System.Drawing.Size(100, 20);
			this.labelCount.TabIndex = 3;
			this.labelCount.Text = "Количество";
			this.labelCount.Visible = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(592, 72);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(176, 63);
			this.button1.TabIndex = 4;
			this.button1.Text = "Подтвердить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// cbCount
			// 
			this.cbCount.FormattingEnabled = true;
			this.cbCount.Location = new System.Drawing.Point(12, 116);
			this.cbCount.Name = "cbCount";
			this.cbCount.Size = new System.Drawing.Size(121, 28);
			this.cbCount.TabIndex = 5;
			this.cbCount.Visible = false;
			this.cbCount.SelectedIndexChanged += new System.EventHandler(this.cbCount_SelectedIndexChanged);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(12, 173);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(143, 47);
			this.buttonAdd.TabIndex = 6;
			this.buttonAdd.Text = "Добавить";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Visible = false;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// dgOD
			// 
			this.dgOD.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dgOD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgOD.Location = new System.Drawing.Point(0, 256);
			this.dgOD.Name = "dgOD";
			this.dgOD.ReadOnly = true;
			this.dgOD.RowHeadersWidth = 62;
			this.dgOD.RowTemplate.Height = 28;
			this.dgOD.Size = new System.Drawing.Size(803, 245);
			this.dgOD.TabIndex = 7;
			// 
			// PrescribeMedicineForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(802, 499);
			this.Controls.Add(this.dgOD);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.cbCount);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.labelCount);
			this.Controls.Add(this.labelMedName);
			this.Controls.Add(this.cbMedName);
			this.Name = "PrescribeMedicineForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Выписывание лекарства";
			((System.ComponentModel.ISupportInitialize)(this.dgOD)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbMedName;
		private System.Windows.Forms.Label labelMedName;
		private System.Windows.Forms.Label labelCount;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox cbCount;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.DataGridView dgOD;
	}
}