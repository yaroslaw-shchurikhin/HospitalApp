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
using static System.Net.WebRequestMethods;

namespace HospitalApp.Supplier.ManageStorage
{
	public partial class ManageStorageForm : Form
	{
		private BindingSource bs = new BindingSource();
		public ManageStorageForm()
		{
			InitializeComponent();

			DataTable dtTmp = new DataTable();

			string strSQL = String.Format(@"SELECT m.name, sm.quantity, sm.unit_price
				FROM SupplierMedicines AS sm
				INNER JOIN Medicines AS m ON m.med_id = sm.med_id 
				INNER JOIN Suppliers AS sp ON sp.sup_id = sm.sup_id
				WHERE sp.passport_num = '{0}'
				GROUP BY m.name, sm.quantity, sm.unit_price", Constants.UserPassport);

			OleDbDataAdapter dAdapter = new OleDbDataAdapter(strSQL, Constants.cn);
			dAdapter.Fill(dtTmp);
			bs.DataSource = dtTmp;
			dgStorage.DataSource = bs;
			dgStorage.AutoSizeColumnsMode =
					 DataGridViewAutoSizeColumnsMode.AllCells;

			// Add a button column. 
			DataGridViewButtonColumn buttonColumn1 =
					new DataGridViewButtonColumn();
			buttonColumn1.HeaderText = "";

			buttonColumn1.Name = "Изменить количество";
			buttonColumn1.Text = "Изменить количество";
			buttonColumn1.UseColumnTextForButtonValue = true;

			dgStorage.Columns.Add(buttonColumn1);

			// Add a button column. 
			DataGridViewButtonColumn buttonColumn2 =
					new DataGridViewButtonColumn();
			buttonColumn2.HeaderText = "";

			buttonColumn2.Name = "Изменить цену";
			buttonColumn2.Text = "Изменить цену";
			buttonColumn2.UseColumnTextForButtonValue = true;

			dgStorage.Columns.Add(buttonColumn2);

			// Add a button column. 
			DataGridViewButtonColumn buttonColumn =
					new DataGridViewButtonColumn();
			buttonColumn.HeaderText = "";

			buttonColumn.Name = "Удалить";
			buttonColumn.Text = "Удалить";
			buttonColumn.UseColumnTextForButtonValue = true;

			dgStorage.Columns.Add(buttonColumn);
		}

		private void dgStorage_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex == dgStorage.Columns["Изменить количество"].Index)
			{
				DataTable medicines = new DataTable();
				string strSQL = String.Format(@"SELECT med_id, name FROM Medicines");
				OleDbDataAdapter dAdapter = new OleDbDataAdapter(strSQL, Constants.cn);
				dAdapter.Fill(medicines);

				int med_id = 0;
				foreach (DataRow row in medicines.Rows)
				{
					if (row["name"].ToString() == dgStorage.Rows[e.RowIndex].Cells[3].Value.ToString())
					{
						med_id = Convert.ToInt32(row["med_id"]);
						break;
					}
				}

				ChangeCountForm ccf = new ChangeCountForm(this, med_id);
				ccf.Show();
			}

			else if (e.RowIndex >= 0 && e.ColumnIndex == dgStorage.Columns["Удалить"].Index)
			{
				DataTable medicines = new DataTable();
				string strSQL = String.Format(@"SELECT med_id, name FROM Medicines");
				OleDbDataAdapter dAdapter = new OleDbDataAdapter(strSQL, Constants.cn);
				dAdapter.Fill(medicines);

				int med_id = 0;
				foreach (DataRow row in medicines.Rows)
				{
					if (row["name"].ToString() == dgStorage.Rows[e.RowIndex].Cells[3].Value.ToString())
					{
						med_id = Convert.ToInt32(row["med_id"]);
						break;
					}
				}


				strSQL = String.Format(@"DELETE FROM SupplierMedicines WHERE sup_id = {0} AND med_id = {1}", Constants.UserPassport[Constants.UserPassport.Length - 1], med_id);
				OleDbCommand cmdIC = new OleDbCommand(strSQL, Constants.cn);
				cmdIC.ExecuteNonQuery();

				ManageStorageForm msf = new ManageStorageForm();
				msf.Show();
				this.Close();
			}

			else if (e.RowIndex >= 0 && e.ColumnIndex == dgStorage.Columns["Изменить цену"].Index)
			{
				DataTable medicines = new DataTable();
				string strSQL = String.Format(@"SELECT med_id, name FROM Medicines");
				OleDbDataAdapter dAdapter = new OleDbDataAdapter(strSQL, Constants.cn);
				dAdapter.Fill(medicines);

				int med_id = 0;
				foreach (DataRow row in medicines.Rows)
				{
					if (row["name"].ToString() == dgStorage.Rows[e.RowIndex].Cells[3].Value.ToString())
					{
						med_id = Convert.ToInt32(row["med_id"]);
						break;
					}
				}

				ChangePriceForm ccf = new ChangePriceForm(this, med_id);
				ccf.Show();
			}
			else return;
		}

		private void buttonAddNewMed_Click(object sender, EventArgs e)
		{
			AddNewItemForm anif = new AddNewItemForm(Constants.UserPassport[Constants.UserPassport.Length - 1], this);
			anif.Show();
		}

		private void buttonBack_Click(object sender, EventArgs e)
		{
			this.Close();
			var sf = new SupplierForm();
			sf.Show();
		}
	}
}
