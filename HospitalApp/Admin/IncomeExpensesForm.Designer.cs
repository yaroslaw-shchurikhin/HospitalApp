namespace HospitalApp.Admin
{
	partial class IncomeExpensesForm
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
			this.labelIncome = new System.Windows.Forms.Label();
			this.labelExpenses = new System.Windows.Forms.Label();
			this.labelDiff = new System.Windows.Forms.Label();
			this.labelIncomeCount = new System.Windows.Forms.Label();
			this.labelExpensesCount = new System.Windows.Forms.Label();
			this.labelDiffCount = new System.Windows.Forms.Label();
			this.buttonOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelIncome
			// 
			this.labelIncome.AutoSize = true;
			this.labelIncome.Location = new System.Drawing.Point(96, 49);
			this.labelIncome.Name = "labelIncome";
			this.labelIncome.Size = new System.Drawing.Size(219, 20);
			this.labelIncome.TabIndex = 0;
			this.labelIncome.Text = "Доход за последний месяц:";
			// 
			// labelExpenses
			// 
			this.labelExpenses.AutoSize = true;
			this.labelExpenses.Location = new System.Drawing.Point(79, 99);
			this.labelExpenses.Name = "labelExpenses";
			this.labelExpenses.Size = new System.Drawing.Size(236, 20);
			this.labelExpenses.TabIndex = 1;
			this.labelExpenses.Text = "Расходы за последний месяц:";
			// 
			// labelDiff
			// 
			this.labelDiff.AutoSize = true;
			this.labelDiff.Location = new System.Drawing.Point(227, 149);
			this.labelDiff.Name = "labelDiff";
			this.labelDiff.Size = new System.Drawing.Size(76, 20);
			this.labelDiff.TabIndex = 2;
			this.labelDiff.Text = "Разница:";
			// 
			// labelIncomeCount
			// 
			this.labelIncomeCount.AutoSize = true;
			this.labelIncomeCount.Location = new System.Drawing.Point(322, 49);
			this.labelIncomeCount.Name = "labelIncomeCount";
			this.labelIncomeCount.Size = new System.Drawing.Size(51, 20);
			this.labelIncomeCount.TabIndex = 3;
			this.labelIncomeCount.Text = "label4";
			// 
			// labelExpensesCount
			// 
			this.labelExpensesCount.AutoSize = true;
			this.labelExpensesCount.Location = new System.Drawing.Point(322, 99);
			this.labelExpensesCount.Name = "labelExpensesCount";
			this.labelExpensesCount.Size = new System.Drawing.Size(51, 20);
			this.labelExpensesCount.TabIndex = 4;
			this.labelExpensesCount.Text = "label5";
			// 
			// labelDiffCount
			// 
			this.labelDiffCount.AutoSize = true;
			this.labelDiffCount.Location = new System.Drawing.Point(322, 149);
			this.labelDiffCount.Name = "labelDiffCount";
			this.labelDiffCount.Size = new System.Drawing.Size(51, 20);
			this.labelDiffCount.TabIndex = 5;
			this.labelDiffCount.Text = "label6";
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new System.Drawing.Point(100, 220);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(336, 44);
			this.buttonOK.TabIndex = 6;
			this.buttonOK.Text = "Хорошо";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// IncomeExpensesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(528, 286);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.labelDiffCount);
			this.Controls.Add(this.labelExpensesCount);
			this.Controls.Add(this.labelIncomeCount);
			this.Controls.Add(this.labelDiff);
			this.Controls.Add(this.labelExpenses);
			this.Controls.Add(this.labelIncome);
			this.Name = "IncomeExpensesForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Доходы и расходы";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelIncome;
		private System.Windows.Forms.Label labelExpenses;
		private System.Windows.Forms.Label labelDiff;
		private System.Windows.Forms.Label labelIncomeCount;
		private System.Windows.Forms.Label labelExpensesCount;
		private System.Windows.Forms.Label labelDiffCount;
		private System.Windows.Forms.Button buttonOK;
	}
}