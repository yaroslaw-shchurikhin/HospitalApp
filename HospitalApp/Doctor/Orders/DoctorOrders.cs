using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalApp.Doctor.Orders
{
	public partial class DoctorOrders : Form
	{
		private bool IsAdmin { get; set; }
		public DoctorOrders(bool isAdmin)
		{
			InitializeComponent();
			IsAdmin = isAdmin;
		}

		private void buttonNewOrders_Click(object sender, EventArgs e)
		{
			this.Close();
			DoctorNewOrdersForm dnof = new DoctorNewOrdersForm(IsAdmin);
			dnof.Show();
		}

		private void buttonOrdersConfirmed_Click(object sender, EventArgs e)
		{
			this.Close();
			DoctorConfirmedOrdersForm dnof = new DoctorConfirmedOrdersForm(IsAdmin);
			dnof.Show();
		}

		private void buttonOrdersArchive_Click(object sender, EventArgs e)
		{
			this.Close();
			DoctorArchiveOrdersForm dnof = new DoctorArchiveOrdersForm(IsAdmin);
			dnof.Show();
		}

		private void buttonBack_Click(object sender, EventArgs e)
		{
			this.Close();
			if (IsAdmin)
			{
				AdminForm af = new AdminForm();
				af.Show();
			}
			else
			{
				DoctorForm df = new DoctorForm();
				df.Show();
			}
		}
	}
}
