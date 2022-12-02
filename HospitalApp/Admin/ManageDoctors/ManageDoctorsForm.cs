using HospitalApp.Admin.ManageDoctors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalApp.Admin
{
	public partial class ManageDoctorsForm : Form
	{
		public ManageDoctorsForm()
		{
			InitializeComponent();
		}

		private void buttonBack_Click(object sender, EventArgs e)
		{
			this.Close();
			AdminForm af = new AdminForm();
			af.Show();
		}

		private void buttonDeleteDoctor_Click(object sender, EventArgs e)
		{
			DeleteDoctorForm ddf = new DeleteDoctorForm();
			ddf.Show();
		}

		private void buttonAddDoctor_Click(object sender, EventArgs e)
		{
			this.Close();
			AddDoctorInfo ddf = new AddDoctorInfo();
			ddf.Show();
		}
	}
}
