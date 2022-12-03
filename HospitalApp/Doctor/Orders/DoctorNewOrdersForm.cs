using HospitalApp.Patient;
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

namespace HospitalApp.Doctor.Orders
{
	public partial class DoctorNewOrdersForm : Form
	{
		private bool IsAdmin { get; set; }
		public DoctorNewOrdersForm(bool isAdmin)
		{
			InitializeComponent();

			BindingSource bs = new BindingSource();
			DataTable dtTmp = new DataTable();

			string strSQL = String.Format(@"SELECT o.order_id, p.first_name, p.last_name, o.date, o.price, os.os_name
			FROM Orders as o
			INNER JOIN Doctors AS d ON d.doctor_id = o.doctor_id
			INNER JOIN OrderStatuses AS os ON os.os_id = o.os_id
			INNER JOIN Patients AS p ON p.patient_id = o.patient_id
			WHERE d.passport_num = '{0}' AND (o.os_id = 1)", Constants.UserPassport);

			OleDbDataAdapter dAdapter = new OleDbDataAdapter(strSQL, Constants.cn);
			dAdapter.Fill(dtTmp);
			bs.DataSource = dtTmp;
			dgDoctorOrders.DataSource = bs;
			dgDoctorOrders.AutoSizeColumnsMode =
					 DataGridViewAutoSizeColumnsMode.AllCells;

			dgDoctorOrders.Columns["order_id"].Visible = false;

			// Add a button column. 
			DataGridViewButtonColumn buttonColumn1 =
					new DataGridViewButtonColumn();
			buttonColumn1.HeaderText = "Отменить приём";

			buttonColumn1.Name = "Отменить";
			buttonColumn1.Text = "Отменить";
			buttonColumn1.UseColumnTextForButtonValue = true;

			dgDoctorOrders.Columns.Add(buttonColumn1);

			// Add a button column. 
			DataGridViewButtonColumn buttonColumn2 =
					new DataGridViewButtonColumn();
			buttonColumn2.HeaderText = "Подтвердить приём";

			buttonColumn2.Name = "Подтвердить";
			buttonColumn2.Text = "Подтвердить";
			buttonColumn2.UseColumnTextForButtonValue = true;

			dgDoctorOrders.Columns.Add(buttonColumn2);
			IsAdmin = isAdmin;
		}

		private void dgDoctorOrders_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex == dgDoctorOrders.Columns["Отменить"].Index)
			{
				var o_id = dgDoctorOrders.Rows[e.RowIndex].Cells[2].Value;
				if (o_id != DBNull.Value)
				{
					string strSQL = String.Format("DELETE FROM Orders WHERE order_id = {0}", Convert.ToInt32(o_id));
					OleDbCommand cmd = new OleDbCommand(strSQL, Constants.cn);
					cmd.ExecuteNonQuery();

					this.Close();
					DoctorNewOrdersForm of = new DoctorNewOrdersForm(IsAdmin);
					of.Show();
				}
			}
			else if (e.RowIndex >= 0 && e.ColumnIndex == dgDoctorOrders.Columns["Подтвердить"].Index)
			{
				var o_id = dgDoctorOrders.Rows[e.RowIndex].Cells[2].Value;
				string strSQL = String.Format("UPDATE Orders SET os_id = 4 WHERE order_id = {0}", Convert.ToInt32(o_id));
				OleDbCommand cmd = new OleDbCommand(strSQL, Constants.cn);
				cmd.ExecuteNonQuery();

				OrderPrice op = new OrderPrice(Convert.ToInt32(o_id), this, IsAdmin);
				op.Show();
			}
		}

		private void buttonBack_Click(object sender, EventArgs e)
		{
			this.Close();
			DoctorOrders pf = new DoctorOrders(IsAdmin);
			pf.Show();
		}
	}
}
