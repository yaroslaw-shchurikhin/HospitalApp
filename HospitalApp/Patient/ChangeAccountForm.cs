using HospitalApp.Model;
using HospitalApp.SupportFuncs;
using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace HospitalApp.Patient
{
	public partial class ChangeAccountForm : Form
	{
		public ChangeAccountForm()
		{
			InitializeComponent();

			DataTable dtTmp = new DataTable();

			string strSQL = String.Format("SELECT * FROM Patients WHERE passport_num = '{0}'", Constants.UserPassport);

			OleDbDataAdapter dAdapter = new OleDbDataAdapter(strSQL, Constants.cn);
			dAdapter.Fill(dtTmp);

			foreach (DataRow row in dtTmp.Rows)
			{
				tbName.Text = row["first_name"].ToString();
				tbLastName.Text = row["last_name"].ToString();

				tbPatronymic.Text = row["patronymic"].ToString();
				tbPhone.Text = row["phone"].ToString();
				tbEmail.Text = row["email"].ToString();

				DateTime birth = DateTime.Parse(row["date_of_birth"].ToString());
				cbDay.Text = birth.Day.ToString();
				cbMonth.Text = SupFuncs.GetMonthFromInt(birth.Month);
				cbYear.Text = birth.Year.ToString();

				if (row["address"].ToString() != String.Empty)
				{
					var address = row["address"].ToString().Split(',');

					switch(address.Length)
					{
						case 1:
							tbStreet.Text = address[0];
							break;
						case 2:
							tbStreet.Text = address[0];
							tbNumOfHouse.Text = address[1];
							break;
						case 3:
							tbStreet.Text = address[0];
							tbNumOfHouse.Text = address[1];
							tbNumOfApartment.Text = address[2];
							break;
					}
				}
			}

			//OleDbCommand command = new OleDbCommand(strSQL, Constants.cn);
			//command.ExecuteNonQuery();
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

			if (isErrors)
			{
				return;
			}

			string str_address = "";
			if (tbNumOfHouse.Text != String.Empty && tbNumOfApartment.Text != String.Empty && tbStreet.Text != String.Empty)
			{
				str_address = tbStreet.Text + "," + tbNumOfHouse.Text + "," + tbNumOfApartment.Text;
			}

			string date = "";
			if(cbYear.Text != string.Empty && cbMonth.Text != string.Empty && cbDay.Text != string.Empty)
			{
				date = cbYear.Text + "-" + cbMonth.Text + "-" + cbDay.Text;
			}

			string strSQL = String.Format("UPDATE Patients SET first_name = '{0}', last_name = '{1}', patronymic = '{2}', phone = '{3}', " +
				"email = '{4}', date_of_birth = '{5}', address = '{6}' WHERE passport_num = '{7}'", 
				tbName.Text, tbLastName.Text, tbPatronymic.Text, tbPhone.Text, tbEmail.Text, date, str_address, Constants.UserPassport);
			OleDbCommand command = new OleDbCommand(strSQL, Constants.cn);
			command.ExecuteNonQuery();

			this.Close();
			PatientForm pf = new PatientForm();
			pf.Show();
		}
	}
}
