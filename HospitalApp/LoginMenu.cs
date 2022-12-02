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

using HospitalApp.SupportFuncs;
using static System.Net.WebRequestMethods;

namespace HospitalApp
{
	public partial class LoginMenu : Form
	{
		DataTable Accounts { get; set; }
		public LoginMenu()
		{
			InitializeComponent();

			Constants.cn.ConnectionString = @"Provider=SQLNCLIRDA11; Data Source=ASUS-ROG\SQLEXPRESS; Integrated Security=SSPI; Initial Catalog=Hospital";
			Constants.cn.Open();
			Accounts = SupFuncs.getAccounts(Constants.cn);
		}
		private void buttonConnect_Click(object sender, EventArgs e)
		{
			var PassNum = tbPasspNum1.Text + tbPasspNum2.Text;
			bool isEntry = false;
			foreach(DataRow accRow in Accounts.Rows) 
			{
				var tmp1 = accRow["passport_num"].ToString();
				var tmp2 = tbPassword.Text.GetHashCode().ToString();
				var tmp3 = accRow["password"].ToString();

				if (PassNum == accRow["passport_num"].ToString() && tbPassword.Text.GetHashCode().ToString() == accRow["password"].ToString())
				{
					isEntry = true;

					// Если дата доставки заказа сегодня - доставляем
					DataTable dtTmp = new DataTable();
					string strSQL = String.Format(@"SELECT ots.ots_id, ots.delivery_date, s.status_name FROM OrdersToSuppliers AS ots " +
					"INNER JOIN Statuses AS s ON s.status_id = ots.status_id " +
					"WHERE (s.status_name = 'on the way')" +
					"GROUP BY ots.ots_id, ots.create_date, ots.delivery_date, s.status_name", Constants.UserPassport);

					OleDbDataAdapter dAdapter = new OleDbDataAdapter(strSQL, Constants.cn);
					dAdapter.Fill(dtTmp);

					foreach (DataRow row in dtTmp.Rows)
					{
						var a = row["delivery_date"].ToString();
						DateTime orderDateTime = DateTime.Parse(row["delivery_date"].ToString());
						if (orderDateTime <= DateTime.Now)
						{
							SupFuncs.DeliverOrder(Convert.ToInt32(row["ots_id"]));
						}
					}

					this.Hide();
					Constants.UserPassport = PassNum;
					switch (Convert.ToInt32(accRow["role_id"]))
					{
						case 1:
							{
								PatientForm pf = new PatientForm();
								pf.ShowDialog();
								break;
							}
						case 2:
							{
								DoctorForm df = new DoctorForm();
								df.ShowDialog();
								break;
							}
						case 3:
							{
								AdminForm af = new AdminForm();
								af.ShowDialog();
								break;
							}
						case 4:
							{
								SupplierForm sf = new SupplierForm();
								sf.ShowDialog();
								break;
							}
					}
				}
			}
			if(!isEntry) MessageBox.Show("Неверный номер паспорта или пароль", "Ошибка входа", MessageBoxButtons.OK);
		}

		private void LoginMenu_FormClosing(object sender, FormClosingEventArgs e)
		{
		}

		private void buttonNoAcc_Click(object sender, EventArgs e)
		{
			this.Hide();
			RegistrationForm rf = new RegistrationForm();
			rf.Show();
		}
		private void checkBoxPasswordShow_CheckedChanged(object sender, EventArgs e)
		{
			tbPassword.UseSystemPasswordChar = !(sender as CheckBox).Checked;
		}

		private void LoginMenu_FormClosed(object sender, FormClosedEventArgs e)
		{

		}

		private void tbPasspNum1_KeyPress(object sender, KeyPressEventArgs e)
		{
			char number = e.KeyChar;
			if (!Char.IsDigit(number))
			{
				e.Handled = true;
			}
		}

		private void tbPasspNum2_KeyPress(object sender, KeyPressEventArgs e)
		{
			char number = e.KeyChar;
			if (!Char.IsDigit(number))
			{
				e.Handled = true;
			}
		}
	}
}
