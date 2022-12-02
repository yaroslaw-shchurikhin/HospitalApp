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
	public partial class AssortimentForm : Form
	{
		public AssortimentForm()
		{
			InitializeComponent();

			OleDbCommand IDS = new OleDbCommand(String.Format("SELECT sup_name FROM Suppliers"), Constants.cn);
			OleDbDataReader rdr = IDS.ExecuteReader();

			while (rdr.Read())
			{
				cbName.Items.Add(rdr["sup_name"]);
			}

			rdr.Close();
		}

		private void cbName_SelectedIndexChanged(object sender, EventArgs e)
		{
			BindingSource bs = new BindingSource();
			DataTable dtTmp = new DataTable();

			string strSQL = String.Format(@"SELECT m.name, sm.quantity, sm.unit_price
				FROM SupplierMedicines AS sm
				INNER JOIN Medicines AS m ON m.med_id = sm.med_id
				INNER JOIN Suppliers AS s ON s.sup_id = sm.sup_id
				WHERE s.sup_name = '{0}' ", cbName.Text);

			OleDbDataAdapter dAdapter = new OleDbDataAdapter(strSQL, Constants.cn);
			dAdapter.Fill(dtTmp);
			bs.DataSource = dtTmp;
			dgAssortiment.DataSource = bs;
			dgAssortiment.AutoSizeColumnsMode =
					 DataGridViewAutoSizeColumnsMode.AllCells;
		}

		private void buttonBack_Click(object sender, EventArgs e)
		{
			this.Close();
			MainOrdersForm mof = new MainOrdersForm();
			mof.Show();
		}
	}
}
