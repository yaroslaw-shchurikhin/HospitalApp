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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

using HospitalApp.SupportFuncs;

namespace HospitalApp.Supplier.ManageOrders
{
	public partial class ChangeOrderStatusForm : Form
	{
		private int OtsID { get; set; }
		private ConfirmedOrdersForm Cof { get; set; }
		public ChangeOrderStatusForm(int ots_id, ConfirmedOrdersForm cof)
		{
			InitializeComponent();

			OleDbCommand IDS = new OleDbCommand("SELECT * FROM Statuses", Constants.cn);
			OleDbDataReader rdr = IDS.ExecuteReader();

			while (rdr.Read())
			{
				if (rdr["status_name"].ToString() != "processed" && rdr["status_name"].ToString() != "confirmed") cbStatus.Items.Add(rdr["status_name"]);
			}

			rdr.Close();

			cbYear.Items.Clear();
			for (int i = 0; i < 3; ++i)
			{
				cbYear.Items.Add(DateTime.Now.Year + i);
			}

			OtsID = ots_id;
			Cof = cof;
		}

		private int MonthToInt(string month)
		{
			switch(month)
			{
				case "Январь":
					return 1;
					break;
				case "Февраль":
					return 2;
					break;
				case "Март":
					return 3;
				case "Апрель":
					return 4;
					break;
				case "Май":
					return 5;
					break;
				case "Июнь":
					return 6;
					break;
				case "Июль":
					return 7;
					break;
				case "Август":
					return 8;
					break;
				case "Сентябрь":
					return 9;
					break;
				case "Октябрь":
					return 10;
					break;
				case "Ноябрь":
					return 11;
					break;
				case "Декабрь":
					return 12;
					break;
				default:
					return 0;
			}
		}

		private int StatusToInt(string status)
		{
			switch (status)
			{
				case "confirmed":
					return 4;
					break;
				case "delivered":
					return 1;
					break;
				case "on the way":
					return 2;
				case "canceled":
					return 5;
					break;
				case "processed":
					return 3;
					break;
				default:
					return 0;
			}
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			bool isErrors = false;

			if (cbStatus.Text == string.Empty)
			{
				isErrors = true;
				labelStatus.ForeColor = Color.Red;
			}

			if (cbStatus.Text == "on the way")
			{
				if (cbDay.Text != string.Empty && (cbMonth.Text == string.Empty || cbYear.Text == string.Empty))
				{
					isErrors = true;
					if (cbYear.Text == string.Empty) labelYear.ForeColor = Color.Red;
					if (cbMonth.Text == string.Empty) labelMonth.ForeColor = Color.Red;
				}

				if (cbMonth.Text != string.Empty && (cbDay.Text == string.Empty || cbYear.Text == string.Empty))
				{
					isErrors = true;
					if (cbDay.Text == string.Empty) labelDay.ForeColor = Color.Red;
					if (cbYear.Text == string.Empty) labelYear.ForeColor = Color.Red;
				}

				if (cbYear.Text != string.Empty && (cbMonth.Text == string.Empty || cbYear.Text == string.Empty))
				{
					isErrors = true;
					if (cbDay.Text == string.Empty) labelDay.ForeColor = Color.Red;
					if (cbMonth.Text == string.Empty) labelMonth.ForeColor = Color.Red;
				}

				if(cbYear.Text == string.Empty && cbMonth.Text == string.Empty && cbDay.Text == string.Empty)
				{
					labelDay.ForeColor = Color.Red;
					labelMonth.ForeColor = Color.Red;
					labelYear.ForeColor = Color.Red;
					isErrors= true;
				}

				if (isErrors)
				{
					return;
				}

				DateTime dt = new DateTime(Convert.ToInt32(cbYear.Text), MonthToInt(cbMonth.Text), Convert.ToInt32(cbDay.Text));
				if (dt < DateTime.Now)
				{
					MessageBox.Show("Введите дату позднее текущей", "Ошибка!", MessageBoxButtons.OK);
					return;
				}

				String strSQL = String.Format(@"UPDATE OrdersToSuppliers SET status_id = 2, delivery_date = '{0}' WHERE ots_id = '{1}'", dt, OtsID);
				OleDbCommand cmdIC = new OleDbCommand(strSQL, Constants.cn);
				cmdIC.ExecuteNonQuery();
			}

			if (isErrors)
			{
				return;
			}

			if (cbStatus.Text == "canceled")
			{
				String strSQL = String.Format(@"UPDATE OrdersToSuppliers SET status_id = 5 WHERE ots_id = '{0}'", OtsID);
				OleDbCommand cmdIC = new OleDbCommand(strSQL, Constants.cn);
				cmdIC.ExecuteNonQuery();

				// Возвращаем товар на склад
				DataTable dtTmp = new DataTable();

				strSQL = String.Format(@"SELECT otsd.med_id, otsd.quantity
				FROM OrdersToSuppliersDetails AS otsd
				INNER JOIN OrdersToSuppliers AS ots on ots.ots_id = otsd.ots_id
				WHERE otsd.ots_id = '{0}'", OtsID);

				OleDbDataAdapter dAdapter = new OleDbDataAdapter(strSQL, Constants.cn);
				dAdapter.Fill(dtTmp);

				foreach (DataRow row in dtTmp.Rows)
				{
					var med_id = row["med_id"];
					var quantity = row["quantity"];

					strSQL = String.Format(@"UPDATE SupplierMedicines SET quantity = quantity + {0} WHERE sup_id = '{1}' AND med_id = '{2}'", Convert.ToInt32(quantity), Constants.UserPassport[Constants.UserPassport.Length - 1], Convert.ToInt32(med_id));
					cmdIC = new OleDbCommand(strSQL, Constants.cn);
					cmdIC.ExecuteNonQuery();
				}
			}
			else if(cbStatus.Text == "delivered")
			{
				SupFuncs.DeliverOrder(OtsID);
			}

			//TODO АВТОМАТИЧЕСКИ МЕНЯТЬ НА DELIVERED ПРИ ДАТЕ ДОСТАВКИ

			this.Close();
			Cof.Close();
			ConfirmedOrdersForm cof = new ConfirmedOrdersForm();
			cof.Show();
		}

		private void cbStatus_TextUpdate(object sender, EventArgs e)
		{
			if (cbStatus.Text == "on the way")
			{
				label1.Visible = true;
				labelDay.Visible = true;
				labelMonth.Visible = true;
				labelYear.Visible = true;
				cbDay.Visible = true;
				cbMonth.Visible = true;
				cbYear.Visible = true;
			}
			else
			{
				label1.Visible = false;
				labelDay.Visible = false;
				labelMonth.Visible = false;
				labelYear.Visible = false;
				cbDay.Visible = false;
				cbMonth.Visible = false;
				cbYear.Visible = false;
			}
		}

		private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
		{
			string selectedState = cbStatus.SelectedItem.ToString();
			if (selectedState == "on the way" || selectedState == "confirmed")
			{
				label1.Visible = true;
				labelDay.Visible = true;
				labelMonth.Visible = true;
				labelYear.Visible = true;
				cbDay.Visible = true;
				cbMonth.Visible = true;
				cbYear.Visible = true;
			}
			else
			{
				label1.Visible = false;
				labelDay.Visible = false;
				labelMonth.Visible = false;
				labelYear.Visible = false;
				cbDay.Visible = false;
				cbMonth.Visible = false;
				cbYear.Visible = false;
			}
		}
	}
}
