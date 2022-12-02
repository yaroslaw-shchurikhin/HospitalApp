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

namespace HospitalApp.Doctor.Orders
{
	public partial class OrderPrice : Form
	{
		private int OrderID { get; set; }

		private bool IsAdmin { get; set; }
		private DoctorNewOrdersForm DNOF { get; set; }
		public OrderPrice(int order_id, DoctorNewOrdersForm dnof, bool isAdmin)
		{
			InitializeComponent();
			OrderID = order_id;
			DNOF = dnof;
			IsAdmin = isAdmin;
		}

		private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
		{
			char number = e.KeyChar;
			if (!Char.IsDigit(number))
			{
				e.Handled = true;
			}
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			try
			{
				int price = Convert.ToInt32(tbPrice.Text);

				OleDbCommand cmd = new OleDbCommand(String.Format("UPDATE Orders SET price = {0} WHERE order_id = {1}", price, OrderID), Constants.cn);
				cmd.ExecuteNonQuery();

				DNOF.Close();
				DoctorOrders of = new DoctorOrders(IsAdmin);
				of.Show();
				this.Close();
			}
			catch(Exception) 
			{
				labelPrice.ForeColor= Color.Red;
				tbPrice.Text = "";
				return;
			}
		}
	}
}
