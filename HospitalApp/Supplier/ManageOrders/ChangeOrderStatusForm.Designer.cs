namespace HospitalApp.Supplier.ManageOrders
{
	partial class ChangeOrderStatusForm
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
			this.cbYear = new System.Windows.Forms.ComboBox();
			this.labelYear = new System.Windows.Forms.Label();
			this.labelMonth = new System.Windows.Forms.Label();
			this.labelDay = new System.Windows.Forms.Label();
			this.cbMonth = new System.Windows.Forms.ComboBox();
			this.cbDay = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cbStatus = new System.Windows.Forms.ComboBox();
			this.labelStatus = new System.Windows.Forms.Label();
			this.buttonOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cbYear
			// 
			this.cbYear.FormattingEnabled = true;
			this.cbYear.Location = new System.Drawing.Point(480, 237);
			this.cbYear.Name = "cbYear";
			this.cbYear.Size = new System.Drawing.Size(121, 28);
			this.cbYear.TabIndex = 33;
			this.cbYear.Visible = false;
			// 
			// labelYear
			// 
			this.labelYear.AutoSize = true;
			this.labelYear.Location = new System.Drawing.Point(483, 210);
			this.labelYear.Name = "labelYear";
			this.labelYear.Size = new System.Drawing.Size(38, 20);
			this.labelYear.TabIndex = 32;
			this.labelYear.Text = "Год";
			this.labelYear.Visible = false;
			// 
			// labelMonth
			// 
			this.labelMonth.AutoSize = true;
			this.labelMonth.Location = new System.Drawing.Point(307, 210);
			this.labelMonth.Name = "labelMonth";
			this.labelMonth.Size = new System.Drawing.Size(57, 20);
			this.labelMonth.TabIndex = 31;
			this.labelMonth.Text = "Месяц";
			this.labelMonth.Visible = false;
			// 
			// labelDay
			// 
			this.labelDay.AutoSize = true;
			this.labelDay.Location = new System.Drawing.Point(224, 211);
			this.labelDay.Name = "labelDay";
			this.labelDay.Size = new System.Drawing.Size(48, 20);
			this.labelDay.TabIndex = 30;
			this.labelDay.Text = "День";
			this.labelDay.Visible = false;
			// 
			// cbMonth
			// 
			this.cbMonth.FormattingEnabled = true;
			this.cbMonth.Items.AddRange(new object[] {
            "Январь",
            "Февраль",
            "Март",
            "Апрель",
            "Май",
            "Июнь",
            "Июль",
            "Август",
            "Сентябрь",
            "Октябрь",
            "Ноябрь",
            "Декабрь"});
			this.cbMonth.Location = new System.Drawing.Point(307, 237);
			this.cbMonth.Name = "cbMonth";
			this.cbMonth.Size = new System.Drawing.Size(160, 28);
			this.cbMonth.TabIndex = 29;
			this.cbMonth.Visible = false;
			// 
			// cbDay
			// 
			this.cbDay.FormattingEnabled = true;
			this.cbDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
			this.cbDay.Location = new System.Drawing.Point(224, 237);
			this.cbDay.Name = "cbDay";
			this.cbDay.Size = new System.Drawing.Size(70, 28);
			this.cbDay.TabIndex = 28;
			this.cbDay.Visible = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(334, 179);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(124, 20);
			this.label1.TabIndex = 27;
			this.label1.Text = "Дата доставки";
			this.label1.Visible = false;
			// 
			// cbStatus
			// 
			this.cbStatus.FormattingEnabled = true;
			this.cbStatus.Location = new System.Drawing.Point(364, 58);
			this.cbStatus.Name = "cbStatus";
			this.cbStatus.Size = new System.Drawing.Size(177, 28);
			this.cbStatus.TabIndex = 34;
			this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
			this.cbStatus.TextUpdate += new System.EventHandler(this.cbStatus_TextUpdate);
			// 
			// labelStatus
			// 
			this.labelStatus.AutoSize = true;
			this.labelStatus.Location = new System.Drawing.Point(230, 61);
			this.labelStatus.Name = "labelStatus";
			this.labelStatus.Size = new System.Drawing.Size(121, 20);
			this.labelStatus.TabIndex = 35;
			this.labelStatus.Text = "Статус заказа:";
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new System.Drawing.Point(257, 340);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(250, 67);
			this.buttonOK.TabIndex = 36;
			this.buttonOK.Text = "Подтвердить";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// ChangeOrderStatusForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.labelStatus);
			this.Controls.Add(this.cbStatus);
			this.Controls.Add(this.cbYear);
			this.Controls.Add(this.labelYear);
			this.Controls.Add(this.labelMonth);
			this.Controls.Add(this.labelDay);
			this.Controls.Add(this.cbMonth);
			this.Controls.Add(this.cbDay);
			this.Controls.Add(this.label1);
			this.Name = "ChangeOrderStatusForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Смена статуса заказа";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbYear;
		private System.Windows.Forms.Label labelYear;
		private System.Windows.Forms.Label labelMonth;
		private System.Windows.Forms.Label labelDay;
		private System.Windows.Forms.ComboBox cbMonth;
		private System.Windows.Forms.ComboBox cbDay;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbStatus;
		private System.Windows.Forms.Label labelStatus;
		private System.Windows.Forms.Button buttonOK;
	}
}