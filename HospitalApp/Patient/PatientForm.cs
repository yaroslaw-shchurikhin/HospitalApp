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

// TODO считаем если больше 10 заказов (считает ХП) - выдаём уведомление о постоянной скидке
namespace HospitalApp
{
	public partial class PatientForm : Form
	{
		List<int> orders_ids = new List<int>();
		public PatientForm()
		{
			InitializeComponent();

			labelDebtCount.Visible = false;
			DataTable dtTmp = new DataTable();

			double sumOfDebt = 0;
			string strSQL = String.Format(@"SELECT pm.quantity, pm.unit_price, pm.order_id
				FROM PrescribedMedications AS pm
				INNER JOIN Orders AS o ON o.order_id = pm.order_id
				INNER JOIN Patients AS p ON p.patient_id = o.patient_id
				WHERE pm.is_paid = 'False' AND p.passport_num = '{0}'", Constants.UserPassport);

			OleDbDataAdapter dAdapter = new OleDbDataAdapter(strSQL, Constants.cn);
			dAdapter.Fill(dtTmp);

			List<int> expenses_list = new List<int>();
			var IDS = new OleDbCommand(String.Format("SELECT d.discount\r\nFROM Discounts AS d\r\nINNER JOIN Patients AS p ON p.disc_id = d.disc_id\r\nWHERE p.passport_num = '{0}' ", Constants.UserPassport), Constants.cn);
			var rdr = IDS.ExecuteReader();

			double discount = 0;
			while (rdr.Read())
			{
				discount = Convert.ToDouble(rdr["discount"]);
			}
			rdr.Close();

			foreach (DataRow row in dtTmp.Rows) 
			{
				sumOfDebt += Convert.ToInt32(row["quantity"]) * Convert.ToInt32(row["unit_price"]);
				orders_ids.Add(Convert.ToInt32(row["order_id"]));
			}

			double temp = discount / 100;
			sumOfDebt *= (double)(discount / 100);
			if (sumOfDebt > 0) 
			{
				labelDebtCount.Visible = true;
				labelDebt.Visible = true;
				buttonPay.Visible = true;

				labelDebtCount.Text = sumOfDebt.ToString();
				labelDebtCount.ForeColor = Color.Red;
			}
		}

		private void buttonOrders_Click(object sender, EventArgs e)
		{
			this.Close();
			OrdersForm pof = new OrdersForm();
			pof.Show();
		}
		private void buttonExit_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Вы уверены, что хотите выйти?", " Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				Constants.cn.Close();
				Application.Exit();
			}
		}

		private void buttonChangePassword_Click(object sender, EventArgs e)
		{
			this.Close();
			ChangeAccountForm caf = new ChangeAccountForm();
			caf.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var cpf = new ChangePasswordForm();
			cpf.Show();
		}

		private void buttonPay_Click(object sender, EventArgs e)
		{
			foreach (var i in orders_ids)
			{
				string strSQL = String.Format(@"UPDATE PrescribedMedications SET is_paid = 'True' WHERE order_id = '{0}'", i);
				OleDbCommand oleDbCommand = new OleDbCommand(strSQL, Constants.cn);
				oleDbCommand.ExecuteNonQuery();
			}

			this.Close();
			PatientForm pf = new PatientForm();
			pf.Show();
		}
	}
}
