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

namespace HospitalApp.Supplier.ManageStorage
{
	public partial class ChangePriceForm : Form
	{
		private ManageStorageForm MSF { get; set; }
		private int MedID { get; set; }
		public ChangePriceForm(ManageStorageForm mSF, int med_id)
		{
			InitializeComponent();
			MSF = mSF;
			MedID = med_id;
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			bool isErrors = false;
			if (tbPrice.Text == string.Empty)
			{
				isErrors = true;
				labelPrice.ForeColor = Color.Red;
			}
			if (isErrors)
			{
				return;
			}

			try
			{
				var a = Convert.ToInt32(tbPrice.Text);
			}
			catch (Exception)
			{
				labelPrice.ForeColor = Color.Red;
				return;
			}

			string strSQL = String.Format(@"UPDATE SupplierMedicines SET unit_price = {0} WHERE sup_id = {1} AND med_id = {2}", tbPrice.Text, Constants.UserPassport[Constants.UserPassport.Length - 1], MedID);
			OleDbCommand cmdIC = new OleDbCommand(strSQL, Constants.cn);
			cmdIC.ExecuteNonQuery();

			MSF.Close();
			var msf = new ManageStorageForm();
			msf.Show();

			this.Close();
		}
	}
}
