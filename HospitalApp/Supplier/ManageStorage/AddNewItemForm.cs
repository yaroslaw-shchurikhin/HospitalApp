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

namespace HospitalApp.Supplier.ManageStorage
{
	public partial class AddNewItemForm : Form
	{
		int SupID { get; set; }
		ManageStorageForm MSF { get; set; }	
		public AddNewItemForm(int sup_id, ManageStorageForm msf)
		{
			InitializeComponent();
			SupID = sup_id;
			MSF = msf;

			DataTable dtSupMed = new DataTable();

			string strSQL = String.Format(@"SELECT m.name 
				FROM SupplierMedicines AS sm
				INNER JOIN Medicines AS m ON m.med_id = sm.med_id 
				INNER JOIN Suppliers AS sp ON sp.sup_id = sm.sup_id
				WHERE sp.passport_num = '{0}'
				GROUP BY m.name", Constants.UserPassport);

			OleDbDataAdapter dAdapter = new OleDbDataAdapter(strSQL, Constants.cn);
			dAdapter.Fill(dtSupMed);

			List<string> medInStorage = new List<string>();
			foreach (DataRow row in dtSupMed.Rows) 
			{
				medInStorage.Add(row["name"].ToString());
			}

			DataTable dtMedAll = new DataTable();
			strSQL = String.Format(@"SELECT m.name 
				FROM Medicines AS m");

			dAdapter = new OleDbDataAdapter(strSQL, Constants.cn);
			dAdapter.Fill(dtMedAll);

			List<string> medAll = new List<string>();
			foreach (DataRow row in dtMedAll.Rows)
			{
				medAll.Add(row["name"].ToString());
			}

			var temp = medAll.Except(medInStorage);
			cbNames.DataSource = temp.ToList();
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			bool isErrors = false;
			if (cbNames.Text == string.Empty)
			{
				isErrors = true;
				labelName.ForeColor = Color.Red;
			}
			if(tbCount.Text == string.Empty)
			{
				isErrors = true;
				labelCount.ForeColor = Color.Red;
			}
			if(tbPrice.Text == string.Empty)
			{
				isErrors = true;
				labelPrice.ForeColor = Color.Red;
			}
			if(isErrors) 
			{
				return; 
			}

			DataTable medicines = new DataTable();
			string strSQL = String.Format(@"SELECT med_id, name FROM Medicines");
			OleDbDataAdapter dAdapter = new OleDbDataAdapter(strSQL, Constants.cn);
			dAdapter.Fill(medicines);

			int med_id = 0;
			foreach (DataRow row in medicines.Rows)
			{
				if (row["name"].ToString() == cbNames.Text)
				{
					med_id = Convert.ToInt32(row["med_id"]);
					break;
				}
			}

			try
			{
				var a = Convert.ToInt32(tbPrice.Text);
			}
			catch(Exception)
			{
				labelPrice.ForeColor = Color.Red;
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

			strSQL = String.Format(@"INSERT INTO SupplierMedicines (sup_id, med_id, unit_price, quantity) VALUES ({0}, {1}, {2}, {3})", Constants.UserPassport[Constants.UserPassport.Length - 1], med_id, tbPrice.Text, tbCount.Text);
			OleDbCommand cmdIC = new OleDbCommand(strSQL, Constants.cn);
			cmdIC.ExecuteNonQuery();

			StoredProcedures.AddNewItemToStorage(Constants.cn, Constants.UserPassport[Constants.UserPassport.Length - 1], med_id, Convert.ToInt32(tbPrice.Text), Convert.ToInt32(tbCount.Text));

			MSF.Close();
			var msf = new ManageStorageForm();
			msf.Show();

			this.Close();
		}
		private void tbCount_KeyPress(object sender, KeyPressEventArgs e)
		{
			char number = e.KeyChar;
			if (!Char.IsDigit(number))
			{
				e.Handled = true;
			}
		}

		private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
		{
			char number = e.KeyChar;

			if (!Char.IsDigit(number))
			{
				e.Handled = true;
			}
		}
	}
}
