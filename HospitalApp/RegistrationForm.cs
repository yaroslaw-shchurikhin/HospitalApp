using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HospitalApp.Model;
using HospitalApp.SupportFuncs;

namespace HospitalApp
{
	public partial class RegistrationForm : Form
	{
		public RegistrationForm()
		{
			InitializeComponent();

		}

		private void checkBoxPasswordShow_CheckedChanged(object sender, EventArgs e)
		{
			tbPassword.UseSystemPasswordChar = !(sender as CheckBox).Checked;
		}

		private void RegistrationForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Constants.cn.Close();
			Application.Exit();
		}

		private void buttonCreateAccount_Click(object sender, EventArgs e)
		{
			bool isErrors = false;
			if(tbName.Text == String.Empty)
			{
				isErrors = true;
				labelName.ForeColor = Color.Red;
			}

			if (tbLastName.Text == String.Empty)
			{
				isErrors = true;
				labelLastName.ForeColor = Color.Red;
			}

			if (tbPasspNum.Text == String.Empty || tbPasspNum.Text.Length != 10)
			{
				isErrors = true;
				labelPassportNum.ForeColor = Color.Red;
			}

			if (tbPassword.Text == String.Empty)
			{
				isErrors = true;
				labelPassword.ForeColor = Color.Red;
			}

			if(cbDay.Text != string.Empty && (cbMonth.Text == string.Empty || cbYear.Text == string.Empty))
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

			User user = new User();

			user.Name = tbName.Text;
			user.Password = tbPassword.Text.GetHashCode().ToString();
			user.Email = tbEmail.Text;
			user.LastName = tbLastName.Text;
			user.Patronymic = tbPatronymic.Text;
			user.PassportNum = tbPasspNum.Text;
			user.Phone= tbPhone.Text;
			if (tbNumOfHouse.Text != String.Empty && tbNumOfApartment.Text != String.Empty && tbStreet.Text != String.Empty)
			{
				user.Address = tbStreet.Text + "," + tbNumOfHouse.Text + "," + tbNumOfApartment.Text;
			}
			else user.Address = "";
			user.DateOfBirth = cbYear.Text + "-" + cbMonth.Text + "-" + cbDay.Text;

			StoredProcedures.AddPatient(Constants.cn, user);
		}

		private void tbPasspNum_KeyPress(object sender, KeyPressEventArgs e)
		{
			char number = e.KeyChar;
			if (!Char.IsDigit(number))
			{
				e.Handled = true;
			}
		}
	}
}
