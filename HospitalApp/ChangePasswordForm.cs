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
	public partial class ChangePasswordForm : Form
	{
		public ChangePasswordForm()
		{
			InitializeComponent();
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			if(tbPassword.Text == string.Empty)
			{
				labelPassword.ForeColor= Color.Red;
				return;
			}

			string strSQL = String.Format("UPDATE Accounts SET password = '{0}' WHERE passport_num = '{1}'", tbPassword.Text.GetHashCode(), Constants.UserPassport);
			OleDbCommand command = new OleDbCommand(strSQL, Constants.cn);
			command.ExecuteNonQuery();
			this.Close();
		}
	}
}
