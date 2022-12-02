using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalApp.Admin.OrdersToSuppliers
{
	public partial class CreateOrderForm : Form
	{
		private int Price { get; set; } = 0;
		private bool firstMed { get; set; } = true;
		private string SupName { get; set; }
		public CreateOrderForm(string sup_name)
		{
			InitializeComponent();

			SupName = sup_name;

			List<string> medicinesAll = new List<string>();
			OleDbCommand IDS = new OleDbCommand(String.Format("SELECT m.name \r\nFROM SupplierMedicines AS sm\r\nINNER JOIN Medicines AS m ON m.med_id = sm.med_id\r\nINNER JOIN Suppliers AS s ON s.sup_id = sm.sup_id\r\nWHERE s.sup_name = '{0}'", SupName), Constants.cn);
			OleDbDataReader rdr = IDS.ExecuteReader();

			while (rdr.Read())
			{
				medicinesAll.Add(rdr["name"].ToString());
			}

			rdr.Close();

			cbMedName.Items.AddRange(medicinesAll.ToArray());
		}
		private void buttonOK_Click(object sender, EventArgs e)
		{
			if (dgOD.Rows.Count == 0)
			{
				MessageBox.Show("Пожалуйста, выберите товары", "Ошибка!", MessageBoxButtons.OK);
				return;
			}

			int sup_id = 0;
			OleDbCommand IDS = new OleDbCommand(String.Format("SELECT sup_id FROM Suppliers WHERE sup_name = '{0}'", SupName), Constants.cn);
			OleDbDataReader rdr = IDS.ExecuteReader();

			while (rdr.Read())
				sup_id = Convert.ToInt32(rdr["sup_id"]);
			rdr.Close();


			string strSQL = String.Format(@"INSERT INTO OrdersToSuppliers (doctor_id, create_date, sup_id, status_id) VALUES (5, '{0}', {1}, 3)", DateTime.Now.ToString("yyyy-MM-dd"), sup_id);
			var cmd = new OleDbCommand(strSQL, Constants.cn);
			cmd.ExecuteNonQuery();

			int order_id = 0;
			IDS = new OleDbCommand(String.Format("SELECT MAX(ots_id) AS max\r\nFROM OrdersToSuppliers"), Constants.cn);
			rdr = IDS.ExecuteReader();

			while (rdr.Read())
				order_id = Convert.ToInt32(rdr["max"]);
			rdr.Close();

			for (int i = 0; i < dgOD.Rows.Count - 1; ++i)
			{
				DataGridViewRow row = dgOD.Rows[i];

				int med_id = 0;
				int med_price = 0;
				int quantity = Convert.ToInt32(row.Cells[1].Value.ToString());

				IDS = new OleDbCommand(String.Format("SELECT sm.unit_price, m.med_id \r\nFROM SupplierMedicines AS sm\r\nINNER JOIN Medicines AS m ON m.med_id = sm.med_id\r\nINNER JOIN Suppliers AS s ON s.sup_id = sm.sup_id\r\n" +
					"WHERE s.sup_name = '{0}' AND m.name = '{1}'", SupName, row.Cells[0].Value.ToString()), Constants.cn);
				rdr = IDS.ExecuteReader();

				while (rdr.Read())
				{
					med_price = Convert.ToInt32(rdr["unit_price"]);
					med_id = Convert.ToInt32(rdr["med_id"]);
				}

				rdr.Close();

				strSQL = String.Format(@"INSERT INTO OrdersToSuppliersDetails (ots_id, med_id, unit_price, quantity, discount) VALUES ({0}, {1}, {2}, {3}, 0)", order_id, med_id, med_price, quantity);
				cmd = new OleDbCommand(strSQL, Constants.cn);
				cmd.ExecuteNonQuery();
			}

			this.Close();
			MainOrdersForm mof = new MainOrdersForm();
			mof.Show();
		}

		private void cbMedName_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			labelCount.Visible = true;
			cbCount.Visible = true;
			cbCount.Items.Clear();
			cbCount.Text = "";

			List<int> quantity = new List<int>();
			OleDbCommand IDS = new OleDbCommand(String.Format("SELECT sm.quantity \r\nFROM SupplierMedicines AS sm\r\nINNER JOIN Medicines AS m ON m.med_id = sm.med_id\r\nINNER JOIN Suppliers AS s ON s.sup_id = sm.sup_id\r\nWHERE s.sup_name = '{0}'", SupName), Constants.cn);
			OleDbDataReader rdr = IDS.ExecuteReader();

			while (rdr.Read())
				quantity.Add(Convert.ToInt32(rdr["quantity"]));
			rdr.Close();

			for (int i = 1; i < quantity[0]; ++i)
			{
				cbCount.Items.Add(i);
			}

			labelPriceCount.Text = Price.ToString();
		}

		private void cbCount_SelectedIndexChanged(object sender, EventArgs e)
		{
			buttonAdd.Visible = true;
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			if (firstMed)
			{
				// Add a columns
				DataGridViewTextBoxColumn Column =
						new DataGridViewTextBoxColumn();
				Column.HeaderText = "Название лекарства";

				dgOD.Columns.Add(Column);

				DataGridViewTextBoxColumn Column2 =
						new DataGridViewTextBoxColumn();
				Column2.HeaderText = "Количество";

				dgOD.Columns.Add(Column2);

				DataGridViewTextBoxColumn Column3 =
						new DataGridViewTextBoxColumn();
				Column3.HeaderText = "Цена за штуку";

				dgOD.Columns.Add(Column3);

				firstMed = false;
			}

			int price = 0;

			OleDbCommand IDS = new OleDbCommand(String.Format("SELECT sm.unit_price\r\nFROM SupplierMedicines AS sm\r\nINNER JOIN Medicines AS m ON m.med_id = sm.med_id\r\nINNER JOIN Suppliers AS s ON s.sup_id = sm.sup_id\r\nWHERE s.sup_name = '{0}' AND m.name = '{1}'", SupName, cbMedName.Text), Constants.cn);
			OleDbDataReader rdr = IDS.ExecuteReader();

			while (rdr.Read())
				price = Convert.ToInt32(rdr["unit_price"]);
			rdr.Close();

			Price += price * Convert.ToInt32(cbCount.Text);
			labelPriceCount.Text = Price.ToString();
			string[] row = new string[] { cbMedName.Text, cbCount.Text, price.ToString() };
			dgOD.Rows.Add(row);

			cbMedName.Text = "";
			cbCount.Text = "";
			cbCount.Items.Clear();

			cbCount.Visible = false;
			labelCount.Visible = false;
			buttonAdd.Visible = false;
		}
	}
}
