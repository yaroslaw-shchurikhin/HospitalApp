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
	public partial class MainOrdersForm : Form
	{
		public MainOrdersForm()
		{
			InitializeComponent();
		}

		private void buttonBack_Click(object sender, EventArgs e)
		{
			this.Close();
			AdminForm af = new AdminForm();
			af.Show();
		}

		private void buttonManageSuppliers_Click(object sender, EventArgs e)
		{
			this.Close();
			ManageSuppliersForm af = new ManageSuppliersForm();
			af.Show();
		}

		private void buttonAssortiment_Click(object sender, EventArgs e)
		{
			this.Close();
			AssortimentForm af = new AssortimentForm();
			af.Show();
		}

		private void buttonOrders_Click(object sender, EventArgs e)
		{
			this.Close();
			OrdersListForm af = new OrdersListForm();
			af.Show();
		}

		private void buttonNewOrder_Click(object sender, EventArgs e)
		{
			this.Close();
			ChooseOrderSupForm af = new ChooseOrderSupForm();
			af.Show();
		}
	}
}
