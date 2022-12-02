namespace HospitalApp.Admin.OrdersToSuppliers
{
	partial class ManageSuppliersForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageSuppliersForm));
			this.buttonBack = new System.Windows.Forms.Button();
			this.buttonDeleteSupplier = new System.Windows.Forms.Button();
			this.buttonAddSupplier = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonBack
			// 
			this.buttonBack.Location = new System.Drawing.Point(14, 11);
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.Size = new System.Drawing.Size(75, 65);
			this.buttonBack.TabIndex = 11;
			this.buttonBack.Text = "Назад";
			this.buttonBack.UseVisualStyleBackColor = true;
			this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
			// 
			// buttonDeleteSupplier
			// 
			this.buttonDeleteSupplier.Location = new System.Drawing.Point(392, 355);
			this.buttonDeleteSupplier.Name = "buttonDeleteSupplier";
			this.buttonDeleteSupplier.Size = new System.Drawing.Size(383, 83);
			this.buttonDeleteSupplier.TabIndex = 10;
			this.buttonDeleteSupplier.Text = "Удалить поставщика";
			this.buttonDeleteSupplier.UseVisualStyleBackColor = true;
			this.buttonDeleteSupplier.Click += new System.EventHandler(this.buttonDeleteSupplier_Click);
			// 
			// buttonAddSupplier
			// 
			this.buttonAddSupplier.Location = new System.Drawing.Point(392, 225);
			this.buttonAddSupplier.Name = "buttonAddSupplier";
			this.buttonAddSupplier.Size = new System.Drawing.Size(383, 83);
			this.buttonAddSupplier.TabIndex = 9;
			this.buttonAddSupplier.Text = "Добавить поставщика";
			this.buttonAddSupplier.UseVisualStyleBackColor = true;
			this.buttonAddSupplier.Click += new System.EventHandler(this.buttonAddSupplier_Click);
			// 
			// ManageSuppliersForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1199, 725);
			this.Controls.Add(this.buttonBack);
			this.Controls.Add(this.buttonDeleteSupplier);
			this.Controls.Add(this.buttonAddSupplier);
			this.DoubleBuffered = true;
			this.Name = "ManageSuppliersForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Управление поставщикаи";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonBack;
		private System.Windows.Forms.Button buttonDeleteSupplier;
		private System.Windows.Forms.Button buttonAddSupplier;
	}
}