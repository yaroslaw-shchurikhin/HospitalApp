using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalApp.Admin.OrdersToSuppliers
{
	public partial class ManageSuppliersForm : Form
	{
		public ManageSuppliersForm()
		{
			InitializeComponent();
		}

		private void buttonBack_Click(object sender, EventArgs e)
		{
			this.Close();
			MainOrdersForm mof = new MainOrdersForm();
			mof.Show();
		}

		private void buttonAddSupplier_Click(object sender, EventArgs e)
		{
			AddSupplierForm asf = new AddSupplierForm();
			asf.Show();
		}

		private void buttonDeleteSupplier_Click(object sender, EventArgs e)
		{
			DeleteSupplierForm asf = new DeleteSupplierForm();
			asf.Show();
		}
	}
}
