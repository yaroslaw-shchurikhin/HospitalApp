namespace HospitalApp.Supplier.ManageStorage
{
	partial class ManageStorageForm
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
			this.buttonBack = new System.Windows.Forms.Button();
			this.dgStorage = new System.Windows.Forms.DataGridView();
			this.buttonAddNewMed = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgStorage)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonBack
			// 
			this.buttonBack.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.buttonBack.Location = new System.Drawing.Point(955, 551);
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.Size = new System.Drawing.Size(156, 100);
			this.buttonBack.TabIndex = 4;
			this.buttonBack.Text = "Назад";
			this.buttonBack.UseVisualStyleBackColor = false;
			this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
			// 
			// dgStorage
			// 
			this.dgStorage.BackgroundColor = System.Drawing.Color.Azure;
			this.dgStorage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgStorage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgStorage.Location = new System.Drawing.Point(0, 0);
			this.dgStorage.Name = "dgStorage";
			this.dgStorage.ReadOnly = true;
			this.dgStorage.RowHeadersWidth = 62;
			this.dgStorage.RowTemplate.Height = 28;
			this.dgStorage.Size = new System.Drawing.Size(1199, 725);
			this.dgStorage.TabIndex = 3;
			this.dgStorage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgStorage_CellClick);
			// 
			// buttonAddNewMed
			// 
			this.buttonAddNewMed.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.buttonAddNewMed.Location = new System.Drawing.Point(955, 262);
			this.buttonAddNewMed.Name = "buttonAddNewMed";
			this.buttonAddNewMed.Size = new System.Drawing.Size(156, 100);
			this.buttonAddNewMed.TabIndex = 5;
			this.buttonAddNewMed.Text = "Добавить новый товар";
			this.buttonAddNewMed.UseVisualStyleBackColor = false;
			this.buttonAddNewMed.Click += new System.EventHandler(this.buttonAddNewMed_Click);
			// 
			// ManageStorageForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1199, 725);
			this.Controls.Add(this.buttonAddNewMed);
			this.Controls.Add(this.buttonBack);
			this.Controls.Add(this.dgStorage);
			this.Name = "ManageStorageForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Управление складом";
			((System.ComponentModel.ISupportInitialize)(this.dgStorage)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonBack;
		private System.Windows.Forms.DataGridView dgStorage;
		private System.Windows.Forms.Button buttonAddNewMed;
	}
}