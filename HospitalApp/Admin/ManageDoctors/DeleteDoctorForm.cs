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
	public partial class DeleteDoctorForm : Form
	{

		private string PassNum { get; set; }
		public DeleteDoctorForm()
		{
			InitializeComponent();

			OleDbCommand IDS = new OleDbCommand(String.Format("SELECT passport_num, first_name, last_name, patronymic FROM Doctors"), Constants.cn);
			OleDbDataReader rdr = IDS.ExecuteReader();

			while (rdr.Read())
			{
				PassNum = rdr["passport_num"].ToString();
				if (PassNum != Constants.UserPassport)
				{
					cbNames.Items.Add(rdr["last_name"].ToString() + " " + rdr["first_name"].ToString() + " " + rdr["patronymic"].ToString());
				}

			}

			rdr.Close();
		}

		private void cbNames_SelectedIndexChanged(object sender, EventArgs e)
		{
			buttonOK.Visible = true;
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			OleDbCommand IDS = new OleDbCommand(String.Format("DELETE FROM Doctors WHERE passport_num = '{0}'", PassNum), Constants.cn);
			IDS.ExecuteNonQuery();

			this.Close();
		}
	}
}
