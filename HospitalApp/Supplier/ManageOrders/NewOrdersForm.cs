using HospitalApp.Model;
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
using System.Windows.Forms.VisualStyles;

namespace HospitalApp.Supplier.ManageOrders
{
	public partial class NewOrdersForm : Form
	{
		private BindingSource bs = new BindingSource();
		public NewOrdersForm()
		{
			InitializeComponent();
			DataTable dtTmp = new DataTable();

			string strSQL = String.Format(@"SELECT ots.ots_id, ots.create_date, ots.delivery_date, s.status_name FROM OrdersToSuppliers AS ots " +
				"INNER JOIN Statuses AS s ON s.status_id = ots.status_id " +
				"INNER JOIN Suppliers AS sp ON sp.sup_id = ots.sup_id " +
				"WHERE (s.status_name = 'processed') AND sp.passport_num = '{0}' " +
				"GROUP BY ots.ots_id, ots.create_date, ots.delivery_date, s.status_name", Constants.UserPassport);

			OleDbDataAdapter dAdapter = new OleDbDataAdapter(strSQL, Constants.cn);
			dAdapter.Fill(dtTmp);
			bs.DataSource = dtTmp;
			dgNewOrders.DataSource = bs;
			dgNewOrders.AutoSizeColumnsMode =
					 DataGridViewAutoSizeColumnsMode.AllCells;

			dgNewOrders.Columns["ots_id"].Visible = false;

			// Add a button column. 
			DataGridViewButtonColumn buttonColumn =
					new DataGridViewButtonColumn();
			buttonColumn.HeaderText = "Подтвердить заказ";
			buttonColumn.Name = "Подтвердить";
			buttonColumn.Text = "Подтвердить";
			buttonColumn.UseColumnTextForButtonValue = true;

			dgNewOrders.Columns.Add(buttonColumn);

			DataGridViewButtonColumn buttonColumn2 =
					new DataGridViewButtonColumn();
			buttonColumn2.HeaderText = "Отменить заказ";
			buttonColumn2.Name = "Отменить";
			buttonColumn2.Text = "Отменить";
			buttonColumn2.UseColumnTextForButtonValue = true;

			dgNewOrders.Columns.Add(buttonColumn2);

			DataGridViewButtonColumn buttonColumn3 =
					new DataGridViewButtonColumn();
			buttonColumn3.HeaderText = "Товары в заказе";
			buttonColumn3.Name = "+";
			buttonColumn3.Text = "+";
			buttonColumn3.UseColumnTextForButtonValue = true;

			dgNewOrders.Columns.Add(buttonColumn3);
		}

		private void dgNewOrders_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			var ots_id = dgNewOrders.Rows[e.RowIndex].Cells[3].Value;
			if (e.RowIndex >= 0 && e.ColumnIndex == dgNewOrders.Columns["Подтвердить"].Index)
			{
				OleDbCommand cmdIC = new OleDbCommand("", Constants.cn);
				// Снять товар со склада
				DataTable dtTmp = new DataTable();

				string strSQL = String.Format(@"SELECT otsd.med_id, otsd.quantity
				FROM OrdersToSuppliersDetails AS otsd
				INNER JOIN OrdersToSuppliers AS ots on ots.ots_id = otsd.ots_id
				WHERE otsd.ots_id = '{0}'", ots_id);

				OleDbDataAdapter dAdapter = new OleDbDataAdapter(strSQL, Constants.cn);
				dAdapter.Fill(dtTmp);

				foreach(DataRow row in dtTmp.Rows)
				{
					var med_id = row["med_id"];
				  var quantity = row["quantity"];

					var c = Constants.UserPassport[Constants.UserPassport.Length - 1];
					strSQL = String.Format(@"SELECT quantity FROM SupplierMedicines WHERE sup_id = '{0}' AND med_id = '{1}'", Constants.UserPassport[Constants.UserPassport.Length - 1], Convert.ToInt32(med_id));
					DataTable dtTmp2 = new DataTable();
					OleDbDataAdapter dAdapter2 = new OleDbDataAdapter(strSQL, Constants.cn);
					dAdapter2.Fill(dtTmp2);
					foreach (DataRow row2 in dtTmp2.Rows)
					{
						if (Convert.ToInt32(row2["quantity"]) - Convert.ToInt32(quantity) < 0)
						{
							MessageBox.Show("Недостаточно товара на складе", "Внимание!", MessageBoxButtons.OK);
							return;
						}
					}

					strSQL = String.Format(@"UPDATE SupplierMedicines SET quantity = quantity - {0} WHERE sup_id = '{1}' AND med_id = '{2}'", Convert.ToInt32(quantity), Constants.UserPassport[Constants.UserPassport.Length - 1], Convert.ToInt32(med_id));
					cmdIC = new OleDbCommand(strSQL, Constants.cn);
					cmdIC.ExecuteNonQuery();
				}

				strSQL = String.Format(@"UPDATE OrdersToSuppliers SET status_id = 4 WHERE ots_id = '{0}'", ots_id);
				cmdIC = new OleDbCommand(strSQL, Constants.cn);
				cmdIC.ExecuteNonQuery();
			}
			else if (e.RowIndex >= 0 && e.ColumnIndex == dgNewOrders.Columns["Отменить"].Index)
			{
				String strSQL = String.Format(@"UPDATE OrdersToSuppliers SET status_id = 5 WHERE ots_id = '{0}'", ots_id);
				OleDbCommand cmdIC = new OleDbCommand(strSQL, Constants.cn);
				cmdIC.ExecuteNonQuery();
			}
			else if (e.RowIndex >= 0 && e.ColumnIndex == dgNewOrders.Columns["+"].Index)
			{
				AddInfoOrders aiof = new AddInfoOrders(Convert.ToInt32(ots_id));
				aiof.Show();
			}
			else return;

			NewOrdersForm nof = new NewOrdersForm();
			nof.Show();
			this.Close();
		}
		private void buttonBack_Click(object sender, EventArgs e)
		{
			Close();
			SupplierManageOrdersForm smof = new SupplierManageOrdersForm();
			smof.Show();
		}
	}
}
