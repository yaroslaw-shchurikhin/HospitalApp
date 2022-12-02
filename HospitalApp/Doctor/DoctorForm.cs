using HospitalApp.Doctor;
using HospitalApp.Doctor.Orders;
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

namespace HospitalApp
{
	public partial class DoctorForm : Form
	{
		public DoctorForm()
		{
			InitializeComponent();
		}

		private void buttonChangePassword_Click(object sender, EventArgs e)
		{
			this.Close();
			ChangeDoctorAccountForm caf = new ChangeDoctorAccountForm(false);
			caf.Show();
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Вы уверены, что хотите выйти?", " Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				Constants.cn.Close();
				Application.Exit();
			}
		}

		private void buttonOrders_Click(object sender, EventArgs e)
		{
			this.Close();
			DoctorOrders dors = new DoctorOrders(false);
			dors.Show();
		}

		private void DoctorForm_FormClosing(object sender, FormClosingEventArgs e)
		{
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var cpf = new ChangePasswordForm();
			cpf.Show();
		}
	}
}
