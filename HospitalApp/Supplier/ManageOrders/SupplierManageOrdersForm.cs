using HospitalApp.Supplier.ManageOrders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalApp
{
	public partial class SupplierManageOrdersForm : Form
	{
		public SupplierManageOrdersForm()
		{
			InitializeComponent();
		}

		private void buttonBack_Click(object sender, EventArgs e)
		{
			this.Close();
			SupplierForm sf = new SupplierForm();
			sf.Show();
		}

		private void buttonOrdersArchive_Click(object sender, EventArgs e)
		{
			this.Close();
			OrdersArchiveForm oaf = new OrdersArchiveForm();
			oaf.Show();
		}

		private void buttonOrdersConfirmed_Click(object sender, EventArgs e)
		{
			this.Close();
			ConfirmedOrdersForm cof = new ConfirmedOrdersForm();
			cof.Show();
		}

		private void buttonNewOrders_Click(object sender, EventArgs e)
		{
			this.Close();
			NewOrdersForm nof = new NewOrdersForm();
			nof.Show();
		}
	}
}
