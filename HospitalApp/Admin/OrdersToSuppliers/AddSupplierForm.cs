using HospitalApp.SupportFuncs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalApp.Admin.OrdersToSuppliers
{
	public partial class AddSupplierForm : Form
	{
		public AddSupplierForm()
		{
			InitializeComponent();
		}

		private void tbLogin_KeyPress(object sender, KeyPressEventArgs e)
		{

		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			bool isErrors = false;
			if (tbLogin.Text == String.Empty || tbLogin.Text.Length != 10)
			{
				isErrors = true;
				labelLogin.ForeColor = Color.Red;
			}

			if (tbName.Text == String.Empty)
			{
				isErrors = true;
				labelName.ForeColor = Color.Red;
			}

			if (tbPassword.Text == String.Empty)
			{
				isErrors = true;
				labelPassword.ForeColor = Color.Red;
			}

			if (isErrors)
			{
				return;
			}

			StoredProcedures.AddSupplier(Constants.cn, tbName.Text, tbPassword.Text.GetHashCode(), tbLogin.Text);

			this.Close();
		}

	}
}
