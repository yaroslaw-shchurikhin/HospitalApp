namespace HospitalApp.Admin
{
	partial class ManageDoctorsForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageDoctorsForm));
			this.buttonAddDoctor = new System.Windows.Forms.Button();
			this.buttonDeleteDoctor = new System.Windows.Forms.Button();
			this.buttonBack = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonAddDoctor
			// 
			this.buttonAddDoctor.Location = new System.Drawing.Point(390, 226);
			this.buttonAddDoctor.Name = "buttonAddDoctor";
			this.buttonAddDoctor.Size = new System.Drawing.Size(383, 83);
			this.buttonAddDoctor.TabIndex = 0;
			this.buttonAddDoctor.Text = "Добавить врача";
			this.buttonAddDoctor.UseVisualStyleBackColor = true;
			this.buttonAddDoctor.Click += new System.EventHandler(this.buttonAddDoctor_Click);
			// 
			// buttonDeleteDoctor
			// 
			this.buttonDeleteDoctor.Location = new System.Drawing.Point(390, 356);
			this.buttonDeleteDoctor.Name = "buttonDeleteDoctor";
			this.buttonDeleteDoctor.Size = new System.Drawing.Size(383, 83);
			this.buttonDeleteDoctor.TabIndex = 1;
			this.buttonDeleteDoctor.Text = "Уволить врача";
			this.buttonDeleteDoctor.UseVisualStyleBackColor = true;
			this.buttonDeleteDoctor.Click += new System.EventHandler(this.buttonDeleteDoctor_Click);
			// 
			// buttonBack
			// 
			this.buttonBack.Location = new System.Drawing.Point(12, 12);
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.Size = new System.Drawing.Size(75, 65);
			this.buttonBack.TabIndex = 8;
			this.buttonBack.Text = "Назад";
			this.buttonBack.UseVisualStyleBackColor = true;
			this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
			// 
			// ManageDoctorsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1199, 725);
			this.Controls.Add(this.buttonBack);
			this.Controls.Add(this.buttonDeleteDoctor);
			this.Controls.Add(this.buttonAddDoctor);
			this.DoubleBuffered = true;
			this.Name = "ManageDoctorsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Управление персоналом";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonAddDoctor;
		private System.Windows.Forms.Button buttonDeleteDoctor;
		private System.Windows.Forms.Button buttonBack;
	}
}