using HospitalApp.SupportFuncs;
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

namespace HospitalApp.Doctor
{
	public partial class ChangeDoctorAccountForm : Form
	{
		private bool IsAdmin { get; set; }
		public ChangeDoctorAccountForm(bool isAdmin)
		{
			InitializeComponent();

			IsAdmin = isAdmin;
			DataTable dtTmp = new DataTable();

			string strSQL = String.Format("SELECT * FROM Doctors WHERE passport_num = '{0}'", Constants.UserPassport);

			OleDbDataAdapter dAdapter = new OleDbDataAdapter(strSQL, Constants.cn);
			dAdapter.Fill(dtTmp);

			foreach (DataRow row in dtTmp.Rows)
			{
				tbName.Text = row["first_name"].ToString();
				tbLastName.Text = row["last_name"].ToString();

				tbPatronymic.Text = row["patronymic"].ToString();
				tbPhone.Text = row["phone"].ToString();
			}
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			bool isErrors = false;
			if (tbName.Text == String.Empty)
			{
				isErrors = true;
				labelName.ForeColor = Color.Red;
			}

			if (tbLastName.Text == String.Empty)
			{
				isErrors = true;
				labelLastName.ForeColor = Color.Red;
			}

			if (isErrors)
			{
				return;
			}

			string strSQL = String.Format("UPDATE Doctors SET first_name = '{0}', last_name = '{1}', patronymic = '{2}', phone = '{3}' " +
				" WHERE passport_num = '{4}'",
				tbName.Text, tbLastName.Text, tbPatronymic.Text, tbPhone.Text, Constants.UserPassport);
			OleDbCommand command = new OleDbCommand(strSQL, Constants.cn);
			command.ExecuteNonQuery();

			this.Close();
			if (IsAdmin)
			{
				AdminForm af = new AdminForm();
				af.Show();
			}
			else
			{
				DoctorForm df = new DoctorForm();
				df.Show();
			}
		}
	}
}
