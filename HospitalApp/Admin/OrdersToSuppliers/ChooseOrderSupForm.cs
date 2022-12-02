using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalApp.Admin.OrdersToSuppliers
{
	public partial class ChooseOrderSupForm : Form
	{
		public ChooseOrderSupForm()
		{
			InitializeComponent();

			OleDbCommand IDS = new OleDbCommand(String.Format("SELECT sup_name FROM Suppliers"), Constants.cn);
			OleDbDataReader rdr = IDS.ExecuteReader();

			while (rdr.Read())
			{
				cbSupName.Items.Add(rdr["sup_name"]);
			}

			rdr.Close();
		}

		private void cbSupName_SelectedIndexChanged(object sender, EventArgs e)
		{
			buttonOK.Visible = true;
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			CreateOrderForm cof = new CreateOrderForm(cbSupName.Text);
			cof.Show();
			Close();
		}
	}
}
