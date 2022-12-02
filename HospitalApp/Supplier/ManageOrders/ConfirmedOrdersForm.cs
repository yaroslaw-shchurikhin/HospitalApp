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

namespace HospitalApp.Supplier.ManageOrders
{
	public partial class ConfirmedOrdersForm : Form
	{
		private BindingSource bs = new BindingSource();
		public ConfirmedOrdersForm()
		{
			InitializeComponent();

			DataTable dtTmp = new DataTable();

			string strSQL = String.Format(@"SELECT ots.ots_id, ots.create_date, ots.delivery_date, s.status_name FROM OrdersToSuppliers AS ots " +
				"INNER JOIN Statuses AS s ON s.status_id = ots.status_id " +
				"INNER JOIN Suppliers AS sp ON sp.sup_id = ots.sup_id " +
				"WHERE (s.status_name = 'on the way' OR s.status_name = 'confirmed') AND sp.passport_num = '{0}' " +
				"GROUP BY ots.ots_id, ots.create_date, ots.delivery_date, s.status_name", Constants.UserPassport);

			OleDbDataAdapter dAdapter = new OleDbDataAdapter(strSQL, Constants.cn);
			dAdapter.Fill(dtTmp);
			bs.DataSource = dtTmp;
			dgConfirmedOrders.DataSource = bs;
			dgConfirmedOrders.AutoSizeColumnsMode =
					 DataGridViewAutoSizeColumnsMode.AllCells;
			dgConfirmedOrders.Columns["ots_id"].Visible = false;

			// Add a button column. 
			DataGridViewButtonColumn buttonColumn1 =
					new DataGridViewButtonColumn();
			buttonColumn1.HeaderText = "Статус";

			buttonColumn1.Name = "Изменить статус";
			buttonColumn1.Text = "Изменить статус";
			buttonColumn1.UseColumnTextForButtonValue = true;

			dgConfirmedOrders.Columns.Add(buttonColumn1);

			// Add a button column. 
			DataGridViewButtonColumn buttonColumn =
					new DataGridViewButtonColumn();
			buttonColumn.HeaderText = "Товары в заказе";

			buttonColumn.Name = "Получить дополнительную информацию";
			buttonColumn.Text = "+";
			buttonColumn.UseColumnTextForButtonValue = true;

			dgConfirmedOrders.Columns.Add(buttonColumn);
		}

		private void dgConfirmedOrders_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex == dgConfirmedOrders.Columns["Получить дополнительную информацию"].Index)
			{
				var ots_id = dgConfirmedOrders.Rows[e.RowIndex].Cells[2].Value;

				AddInfoOrders aiof = new AddInfoOrders(Convert.ToInt32(ots_id));
				aiof.Show();
			}
			else if (e.RowIndex >= 0 && e.ColumnIndex == dgConfirmedOrders.Columns["Изменить статус"].Index)
			{
				var ots_id = dgConfirmedOrders.Rows[e.RowIndex].Cells[2].Value;

				ChangeOrderStatusForm cosf = new ChangeOrderStatusForm(Convert.ToInt32(ots_id), this);
				cosf.Show();
			}
			else return;
		}

		private void buttonBack_Click(object sender, EventArgs e)
		{
			Close();
			SupplierManageOrdersForm smof = new SupplierManageOrdersForm();
			smof.Show();
		}
	}
}
