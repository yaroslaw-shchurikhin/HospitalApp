using HospitalApp.Model;
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

namespace HospitalApp.Admin.ManageDoctors
{
	public partial class AddDoctorInfo : Form
	{
		public AddDoctorInfo()
		{
			InitializeComponent();

			OleDbCommand IDS = new OleDbCommand(String.Format("SELECT spec_name FROM Specializations"), Constants.cn);
			OleDbDataReader rdr = IDS.ExecuteReader();

			while (rdr.Read())
			{
				clbSpecs.Items.Add(rdr["spec_name"]);
			}
			rdr.Close();

			IDS = new OleDbCommand(String.Format("SELECT pos_name FROM Positions"), Constants.cn);
			rdr = IDS.ExecuteReader();

			while (rdr.Read())
			{
				cbPosition.Items.Add(rdr["pos_name"]);
			}
			rdr.Close();
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

			if(clbSpecs.CheckedItems.Count == 0) 
			{
				isErrors = true;
				label1ChooseSpecs.ForeColor = Color.Red;
			}

			if (tbPasspNum.Text == String.Empty)
			{
				isErrors = true;
				labelPassportNum.ForeColor = Color.Red;
			}

			if (tbPassword.Text == String.Empty)
			{
				isErrors = true;
				labelPassword.ForeColor = Color.Red;
			}

			if(cbPosition.Text == String.Empty)
			{
				isErrors = true;
				labelPos.ForeColor = Color.Red;
			}

			if (isErrors)
			{
				return;
			}

			List<string> specs = new List<string>();
			foreach(var j in clbSpecs.CheckedItems)
			{
				specs.Add(j.ToString());
			}
			int i = 0;
			++i;

			User user = new User();
			user.Name = tbName.Text;
			user.Password = tbPassword.Text.GetHashCode().ToString();
			user.LastName = tbLastName.Text;
			user.Patronymic = tbPatronymic.Text;
			user.PassportNum = tbPasspNum.Text;
			user.Phone = tbPhone.Text;

			int pos_id = 0;


			OleDbCommand IDS = new OleDbCommand(String.Format("SELECT pos_id, pos_name FROM Positions"), Constants.cn);
			var rdr = IDS.ExecuteReader();

			while (rdr.Read())
			{
				if (rdr["pos_name"].ToString() == cbPosition.Text)
				{
					pos_id = Convert.ToInt32(rdr["pos_id"]);
				}
			}
			rdr.Close();


			StoredProcedures.AddDoctor(Constants.cn, user, specs, pos_id);

			this.Close();
			ManageDoctorsForm mdf = new ManageDoctorsForm();
			mdf.Show();
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
