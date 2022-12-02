using HospitalApp.Admin;
using HospitalApp.Admin.OrdersToSuppliers;
using HospitalApp.Doctor;
using HospitalApp.Doctor.Orders;
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
	public partial class AdminForm : Form
	{ 
		public AdminForm()
		{
			InitializeComponent();

		}

		private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
		{
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Вы уверены, что хотите выйти?", " Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				Constants.cn.Close();
				Application.Exit();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var cpf = new ChangePasswordForm();
			cpf.Show();
		}

		private void buttonChangePassword_Click(object sender, EventArgs e)
		{
			this.Close();
			ChangeDoctorAccountForm caf = new ChangeDoctorAccountForm(true);
			caf.Show();
		}

		private void buttonOrders_Click(object sender, EventArgs e)
		{
			this.Close();
			DoctorOrders df = new DoctorOrders(true);
			df.Show();
		}

		private void buttonSupplierOrders_Click(object sender, EventArgs e)
		{
			this.Close();
			MainOrdersForm df = new MainOrdersForm();
			df.Show();
		}

		private void buttonIncomeExpenses_Click(object sender, EventArgs e)
		{
			IncomeExpensesForm ief = new IncomeExpensesForm();
			ief.Show();
		}

		private void buttonManageEmployees_Click(object sender, EventArgs e)
		{
			this.Close();
			ManageDoctorsForm mdf = new ManageDoctorsForm();
			mdf.Show();
		}
	}
}
