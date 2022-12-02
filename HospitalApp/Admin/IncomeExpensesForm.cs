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

namespace HospitalApp.Admin
{
	public partial class IncomeExpensesForm : Form
	{
		public IncomeExpensesForm()
		{
			InitializeComponent();

			labelIncome.ForeColor = Color.Green;
			labelIncomeCount.ForeColor = Color.Green;
			labelExpenses.ForeColor = Color.Red;
			labelExpensesCount.ForeColor = Color.Red;

			int income = 0;
			int expenses = 0;

			//TODO
			List<int> incomes = new List<int>();
			OleDbCommand IDS = new OleDbCommand(String.Format("SELECT o.price\r\nFROM Orders AS o\r\nWHERE o.date > DATEADD(day, -30, GETDATE()) AND o.date < GETDATE()"), Constants.cn);
			OleDbDataReader rdr = IDS.ExecuteReader();

			while (rdr.Read())
			{
				incomes.Add(Convert.ToInt32(rdr["price"]));
			}

			rdr.Close();

			List<int> expenses_list = new List<int>();
			IDS = new OleDbCommand(String.Format("SELECT pm.unit_price, pm.quantity\r\nFROM PrescribedMedications AS pm\r\nINNER JOIN Orders AS o ON o.order_id = pm.order_id\r\nWHERE pm.is_paid = 'False' AND o.date > DATEADD(day, -30, GETDATE()) AND o.date < GETDATE()"), Constants.cn);
			rdr = IDS.ExecuteReader();

			while (rdr.Read())
			{
				expenses_list.Add(Convert.ToInt32(rdr["quantity"]) * Convert.ToInt32(rdr["unit_price"]));
			}
			rdr.Close();

			IDS = new OleDbCommand(String.Format("SELECT otsd.quantity, otsd.unit_price\r\nFROM OrdersToSuppliers AS ots\r\nINNER JOIN OrdersToSuppliersDetails AS otsd ON otsd.ots_id = ots.ots_id\r\nWHERE ots.create_date > DATEADD(day, -30, GETDATE()) AND ots.create_date < GETDATE()"), Constants.cn);
			rdr = IDS.ExecuteReader();

			while (rdr.Read())
			{
				expenses_list.Add(Convert.ToInt32(rdr["quantity"]) * Convert.ToInt32(rdr["unit_price"]));
			}
			rdr.Close();

			foreach(var i in expenses_list)
			{
				expenses += i;
			}

			foreach (var i in incomes)
			{
				income += i;
			}

			int difference = income - expenses;
			labelIncomeCount.Text = income.ToString();
			labelExpensesCount.Text = expenses.ToString();
			labelDiffCount.Text = difference.ToString();
			if (difference > 0)
			{
				buttonOK.Text = "Отличный месяц!";
				labelDiff.ForeColor = Color.Green;
				labelDiffCount.ForeColor = Color.Green;
			}
			else if (difference < 0)
			{
				buttonOK.Text = "Надо работать усерднее...";
				labelDiff.ForeColor = Color.Red;
				labelDiffCount.ForeColor = Color.Red;
			}
			else
			{
				buttonOK.Text = "Ну...Зато не в минус";
				labelDiff.ForeColor = Color.Yellow;
				labelDiffCount.ForeColor = Color.Yellow;
			}
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
