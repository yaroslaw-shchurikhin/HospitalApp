namespace HospitalApp.Admin.OrdersToSuppliers
{
	partial class CreateOrderForm
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
			this.dgOD = new System.Windows.Forms.DataGridView();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.cbCount = new System.Windows.Forms.ComboBox();
			this.buttonOK = new System.Windows.Forms.Button();
			this.labelCount = new System.Windows.Forms.Label();
			this.labelMedName = new System.Windows.Forms.Label();
			this.cbMedName = new System.Windows.Forms.ComboBox();
			this.labelName = new System.Windows.Forms.Label();
			this.labelPrice = new System.Windows.Forms.Label();
			this.labelPriceCount = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgOD)).BeginInit();
			this.SuspendLayout();
			// 
			// dgOD
			// 
			this.dgOD.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dgOD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgOD.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dgOD.Location = new System.Drawing.Point(0, 242);
			this.dgOD.Name = "dgOD";
			this.dgOD.ReadOnly = true;
			this.dgOD.RowHeadersWidth = 62;
			this.dgOD.RowTemplate.Height = 28;
			this.dgOD.Size = new System.Drawing.Size(888, 311);
			this.dgOD.TabIndex = 14;
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(11, 176);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(143, 47);
			this.buttonAdd.TabIndex = 13;
			this.buttonAdd.Text = "Добавить";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Visible = false;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// cbCount
			// 
			this.cbCount.FormattingEnabled = true;
			this.cbCount.Location = new System.Drawing.Point(12, 130);
			this.cbCount.Name = "cbCount";
			this.cbCount.Size = new System.Drawing.Size(121, 28);
			this.cbCount.TabIndex = 12;
			this.cbCount.Visible = false;
			this.cbCount.SelectedIndexChanged += new System.EventHandler(this.cbCount_SelectedIndexChanged);
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new System.Drawing.Point(624, 95);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(176, 63);
			this.buttonOK.TabIndex = 11;
			this.buttonOK.Text = "Подтвердить";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// labelCount
			// 
			this.labelCount.AutoSize = true;
			this.labelCount.Location = new System.Drawing.Point(7, 107);
			this.labelCount.Name = "labelCount";
			this.labelCount.Size = new System.Drawing.Size(100, 20);
			this.labelCount.TabIndex = 10;
			this.labelCount.Text = "Количество";
			this.labelCount.Visible = false;
			// 
			// labelMedName
			// 
			this.labelMedName.AutoSize = true;
			this.labelMedName.Location = new System.Drawing.Point(11, -20);
			this.labelMedName.Name = "labelMedName";
			this.labelMedName.Size = new System.Drawing.Size(168, 20);
			this.labelMedName.TabIndex = 9;
			this.labelMedName.Text = "Название препарата";
			// 
			// cbMedName
			// 
			this.cbMedName.ForeColor = System.Drawing.Color.Black;
			this.cbMedName.FormattingEnabled = true;
			this.cbMedName.Location = new System.Drawing.Point(11, 60);
			this.cbMedName.Name = "cbMedName";
			this.cbMedName.Size = new System.Drawing.Size(168, 28);
			this.cbMedName.TabIndex = 8;
			this.cbMedName.SelectedIndexChanged += new System.EventHandler(this.cbMedName_SelectedIndexChanged_1);
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(11, 34);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(167, 20);
			this.labelName.TabIndex = 15;
			this.labelName.Text = "Название лекарства";
			// 
			// labelPrice
			// 
			this.labelPrice.AutoSize = true;
			this.labelPrice.Location = new System.Drawing.Point(623, 63);
			this.labelPrice.Name = "labelPrice";
			this.labelPrice.Size = new System.Drawing.Size(107, 20);
			this.labelPrice.TabIndex = 16;
			this.labelPrice.Text = "Цена заказа:";
			// 
			// labelPriceCount
			// 
			this.labelPriceCount.AutoSize = true;
			this.labelPriceCount.Location = new System.Drawing.Point(737, 63);
			this.labelPriceCount.Name = "labelPriceCount";
			this.labelPriceCount.Size = new System.Drawing.Size(51, 20);
			this.labelPriceCount.TabIndex = 17;
			this.labelPriceCount.Text = "label2";
			// 
			// CreateOrderForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(888, 553);
			this.Controls.Add(this.labelPriceCount);
			this.Controls.Add(this.labelPrice);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.dgOD);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.cbCount);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.labelCount);
			this.Controls.Add(this.labelMedName);
			this.Controls.Add(this.cbMedName);
			this.Name = "CreateOrderForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Выбор товара";
			((System.ComponentModel.ISupportInitialize)(this.dgOD)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgOD;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.ComboBox cbCount;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Label labelCount;
		private System.Windows.Forms.Label labelMedName;
		private System.Windows.Forms.ComboBox cbMedName;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelPrice;
		private System.Windows.Forms.Label labelPriceCount;
	}
}