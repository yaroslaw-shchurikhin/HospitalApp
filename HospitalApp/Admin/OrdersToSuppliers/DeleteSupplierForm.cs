using HospitalApp.SupportFuncs;
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
	public partial class DeleteSupplierForm : Form
	{
		public DeleteSupplierForm()
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

		private void buttonOK_Click(object sender, EventArgs e)
		{
			if(cbSupName.Text == "")
			{
				labelName.ForeColor = Color.Red;
				return;
			}
			StoredProcedures.DeleteSupplier(Constants.cn, cbSupName.Text);

			this.Close();
		}
	}
}
