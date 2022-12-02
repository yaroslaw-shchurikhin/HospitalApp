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
	public partial class ChangeCountForm : Form
	{
		private ManageStorageForm MSF { get; set; }
		private int MedID { get; set; }	
		public ChangeCountForm(ManageStorageForm mSF, int med_id)
		{
			InitializeComponent();
			MSF = mSF;
			MedID = med_id;
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			bool isErrors = false;
			if (tbCount.Text == string.Empty)
			{
				isErrors = true;
				labelCount.ForeColor = Color.Red;
			}
			if (isErrors)
			{
				return;
			}

			try
			{
				var a = Convert.ToInt32(tbCount.Text);
			}
			catch (Exception)
			{
				labelCount.ForeColor = Color.Red;
				return;
			}

			string strSQL = String.Format(@"UPDATE SupplierMedicines SET quantity = quantity + {0} WHERE sup_id = {1} AND med_id = {2}", tbCount.Text, Constants.UserPassport[Constants.UserPassport.Length - 1], MedID);
			OleDbCommand cmdIC = new OleDbCommand(strSQL, Constants.cn);
			cmdIC.ExecuteNonQuery();

			MSF.Close();
			var msf = new ManageStorageForm();
			msf.Show();

			this.Close();
		}
	}
}
