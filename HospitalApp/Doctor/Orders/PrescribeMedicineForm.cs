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
	public partial class PrescribeMedicineForm : Form
	{
		private bool firstMed { get; set; } = true;
		private int OrderID { get; set; }	
		public PrescribeMedicineForm(int order_id)
		{
			InitializeComponent();

			OrderID = order_id;

			List<string> medicinesAll = new List<string>();
			OleDbCommand IDS = new OleDbCommand("SELECT name FROM Medicines", Constants.cn);
			OleDbDataReader rdr = IDS.ExecuteReader();

			while (rdr.Read())
			{
				medicinesAll.Add(rdr["name"].ToString());
			}

			rdr.Close();

			//TODO удалить все лекарства, которые уже выписаны к этому заказу
			IDS = new OleDbCommand(String.Format("SELECT m.name\r\nFROM PrescribedMedications AS pm\r\nINNER JOIN Medicines AS m ON m.med_id = pm.med_id\r\nWHERE pm.order_id = {0}", OrderID), Constants.cn);
			rdr = IDS.ExecuteReader();
			List<string> medicines = new List<string>();

			while (rdr.Read())
			{
				medicines.Add(rdr["name"].ToString());
			}

			cbMedName.Items.AddRange(medicinesAll.Except(medicines).ToArray());

			rdr.Close();
		}

		private void cbMedName_SelectedIndexChanged(object sender, EventArgs e)
		{
			labelCount.Visible = true;
			cbCount.Visible = true;
			cbCount.Items.Clear();
			cbCount.Text = "";

			List<int> quantity = new List<int>();
			OleDbCommand IDS = new OleDbCommand(String.Format("SELECT quantity FROM Medicines WHERE name = '{0}'", cbMedName.Text), Constants.cn);
			OleDbDataReader rdr = IDS.ExecuteReader();

			while (rdr.Read())
				quantity.Add(Convert.ToInt32(rdr["quantity"]));
			rdr.Close();

			for(int i = 1; i < quantity[0]; ++i)
			{
				cbCount.Items.Add(i);
			}
		}

		private void cbCount_SelectedIndexChanged(object sender, EventArgs e)
		{
			buttonAdd.Visible = true;
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			if (firstMed)
			{
				// Add a columns
				DataGridViewTextBoxColumn Column =
						new DataGridViewTextBoxColumn();
				Column.HeaderText = "Название лекарства";

				dgOD.Columns.Add(Column);

				DataGridViewTextBoxColumn Column2 =
						new DataGridViewTextBoxColumn();
				Column2.HeaderText = "Количество";

				dgOD.Columns.Add(Column2);

				firstMed = false;
			}

			string[] row = new string[] { cbMedName.Text, cbCount.Text };
			dgOD.Rows.Add(row);

			cbMedName.Text = "";
			cbCount.Text = "";
			cbCount.Items.Clear();

			cbCount.Visible = false;
			labelCount.Visible= false;
			buttonAdd.Visible = false;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if(dgOD.Rows.Count == 0) 
			{
				return;
			}

			int order_id = OrderID;
			int med_id = 0;
			int quantity = 0;
			int unit_price = 0;

			for(int i = 0; i < dgOD.Rows.Count - 1; ++i) 
			{
				DataGridViewRow row = dgOD.Rows[i];
				List<int> medicines_id = new List<int>();
				List<int> medicines_unit_price = new List<int>();
				OleDbCommand IDS = new OleDbCommand(String.Format("SELECT * FROM Medicines WHERE name = '{0}'", row.Cells[0].Value.ToString()), Constants.cn);
				OleDbDataReader rdr = IDS.ExecuteReader();

				while (rdr.Read())
				{
					medicines_id.Add(Convert.ToInt32(rdr["med_id"]));
					medicines_unit_price.Add(Convert.ToInt32(rdr["price"]));
				}
				rdr.Close();

				med_id = medicines_id[0];
				unit_price = medicines_unit_price[0];
				quantity = Convert.ToInt32(row.Cells[1].Value.ToString());
				string strSQL = String.Format(@"INSERT INTO PrescribedMedications (order_id, med_id, quantity, unit_price, is_paid) VALUES ({0}, {1}, {2}, {3}, 'False')", order_id, med_id, quantity, unit_price);
				var cmd = new OleDbCommand(strSQL, Constants.cn);
				cmd.ExecuteNonQuery();
			}

			this.Close();
		}
	}
}
