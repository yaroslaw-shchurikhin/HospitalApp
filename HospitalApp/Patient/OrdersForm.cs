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

namespace HospitalApp.Patient
{
	public partial class OrdersForm : Form
	{
		public OrdersForm()
		{
			InitializeComponent();

			BindingSource bs = new BindingSource();
			DataTable dtTmp = new DataTable();

			string strSQL = String.Format(@"SELECT o.order_id, d.first_name, d.last_name, o.date, o.price, os.os_name
			FROM Orders as o
			INNER JOIN Doctors AS d ON d.doctor_id = o.doctor_id
			INNER JOIN OrderStatuses AS os ON os.os_id = o.os_id
			INNER JOIN Patients AS p ON p.patient_id = o.patient_id
			WHERE p.passport_num = '{0}' AND (o.os_id = 1 OR o.os_id = 4)", Constants.UserPassport);

			OleDbDataAdapter dAdapter = new OleDbDataAdapter(strSQL, Constants.cn);
			dAdapter.Fill(dtTmp);
			bs.DataSource = dtTmp;
			dgPatientOrders.DataSource = bs;
			dgPatientOrders.AutoSizeColumnsMode =
					 DataGridViewAutoSizeColumnsMode.AllCells;

			dgPatientOrders.Columns["order_id"].Visible = false;

			// Add a button column. 
			DataGridViewButtonColumn buttonColumn1 =
					new DataGridViewButtonColumn();
			buttonColumn1.HeaderText = "Отменить приём";

			buttonColumn1.Name = "Отменить";
			buttonColumn1.Text = "Отменить";
			buttonColumn1.UseColumnTextForButtonValue = true;

			dgPatientOrders.Columns.Add(buttonColumn1);
		}

		private void buttonAddOrder_Click(object sender, EventArgs e)
		{
			AddPatientOrderForm apof = new AddPatientOrderForm(this);
			apof.Show();
		}

		private void buttonBack_Click(object sender, EventArgs e)
		{
			this.Close();
			PatientForm pf = new PatientForm();
			pf.Show();
		}

		private void dgPatientOrders_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex == dgPatientOrders.Columns["Отменить"].Index)
			{
				var o_id = dgPatientOrders.Rows[e.RowIndex].Cells[1].Value;
				string strSQL = String.Format("DELETE FROM Orders WHERE order_id = {0}", Convert.ToInt32(o_id));
				OleDbCommand cmd = new OleDbCommand(strSQL, Constants.cn);
				cmd.ExecuteNonQuery();
			}

			this.Close();
			OrdersForm of = new OrdersForm();
			of.Show();
		}

		private void dgPatientOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
