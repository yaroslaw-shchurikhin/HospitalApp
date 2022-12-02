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

using HospitalApp.Supplier.ManageOrders;
using HospitalApp.Supplier.ManageStorage;

namespace HospitalApp
{
	public partial class SupplierForm : Form
	{		public SupplierForm()
		{
			InitializeComponent();
		}

		private void SupplierForm_FormClosing(object sender, FormClosingEventArgs e)
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

		private void buttonOrders_Click(object sender, EventArgs e)
		{
			this.Close();
			var smof = new SupplierManageOrdersForm();
			smof.Show();
		}

		private void buttonStorage_Click(object sender, EventArgs e)
		{
			this.Close();
			var msf = new ManageStorageForm();
			msf.Show();
		}

		private void buttonChangePassword_Click(object sender, EventArgs e)
		{
			var cpf = new ChangePasswordForm();
			cpf.Show();
		}
	}
}
