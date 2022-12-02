using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalApp.Supplier.ManageOrders
{
	public partial class OrdersArchiveForm : Form
	{
		private BindingSource bs = new BindingSource();
		public OrdersArchiveForm()
		{
			InitializeComponent();
			DataTable dtTmp = new DataTable();

			string strSQL = String.Format(@"SELECT ots.ots_id, ots.create_date, ots.delivery_date, s.status_name FROM OrdersToSuppliers AS ots " +
				"INNER JOIN Statuses AS s ON s.status_id = ots.status_id " +
				"INNER JOIN Suppliers AS sp ON sp.sup_id = ots.sup_id " +
				"WHERE (s.status_name = 'delivered' OR s.status_name = 'canceled') AND sp.passport_num = '{0}' " +
				"GROUP BY ots.ots_id, ots.create_date, ots.delivery_date, s.status_name", Constants.UserPassport);

			OleDbDataAdapter dAdapter = new OleDbDataAdapter(strSQL, Constants.cn);
			dAdapter.Fill(dtTmp);
			bs.DataSource = dtTmp;
			dgArchiveOrders.DataSource = bs;
			dgArchiveOrders.AutoSizeColumnsMode =
					 DataGridViewAutoSizeColumnsMode.AllCells;

			dgArchiveOrders.Columns["ots_id"].Visible = false;

			// Add a button column. 
			DataGridViewButtonColumn buttonColumn =
					new DataGridViewButtonColumn();
			buttonColumn.HeaderText = "Товары в заказе";
			buttonColumn.Name = "Получить дополнительную информацию";
			buttonColumn.Text = "+";
			buttonColumn.UseColumnTextForButtonValue = true;

			dgArchiveOrders.Columns.Add(buttonColumn);
		}

		private void dgArchiveOrders_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0 || e.ColumnIndex !=
					 dgArchiveOrders.Columns["Получить дополнительную информацию"].Index) return;

			var ots_id = dgArchiveOrders.Rows[e.RowIndex].Cells[1].Value;

			AddInfoOrders aiof = new AddInfoOrders(Convert.ToInt32(ots_id));
			aiof.Show();
		}

		private void buttonBack_Click(object sender, EventArgs e)
		{
			Close();
			SupplierManageOrdersForm smof = new SupplierManageOrdersForm();
			smof.Show();
		}
	}
}
