using HospitalApp.SupportFuncs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace HospitalApp.Patient
{
	public partial class AddPatientOrderForm : Form
	{
		OrdersForm OF { get; set; }
		public AddPatientOrderForm(OrdersForm of)
		{
			InitializeComponent();
			OF = of;
			DataTable dtSpecs= new DataTable();

			//Specialization ComboBox
			string strSQL = "SELECT spec_name FROM Specializations";
			OleDbDataAdapter dAdapterSpecs = new OleDbDataAdapter(strSQL, Constants.cn);
			dAdapterSpecs.Fill(dtSpecs);


			labelDoctorName.Visible = false;
			labelDate.Visible = false;
			labelTime.Visible = false;
			cbDoctorName.Visible = false;
			cbDate.Visible = false;
			cbTime.Visible = false;

			foreach(DataRow row in dtSpecs.Rows)
			{
				cbDoctorSpec.Items.Add(row["spec_name"].ToString());
			}
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			string dName = (string)cbDoctorName.Text.Split(' ')[0];
			string dLastName = (string)cbDoctorName.Text.Split(' ')[1];

			int doctor_id = 0;
			int patient_id = 0;

			// DoctorID
			DataTable dtDoctorID = new DataTable();
			string strSQL = "SELECT doctor_id, first_name, last_name FROM Doctors";
			OleDbDataAdapter dAdapterDoctorID = new OleDbDataAdapter(strSQL, Constants.cn);
			dAdapterDoctorID.Fill(dtDoctorID);

			foreach(DataRow row in dtDoctorID.Rows)
			{
				if (row["first_name"].ToString() + ' ' + row["last_name"].ToString() == cbDoctorName.Text)
				{
					doctor_id = Convert.ToInt32(row["doctor_id"]);
				}
			}

			// 
			DataTable dtPatientID = new DataTable();
			strSQL = "SELECT passport_num, patient_id FROM Patients";
			OleDbDataAdapter dAdapterPatientID = new OleDbDataAdapter(strSQL, Constants.cn);
			dAdapterPatientID.Fill(dtPatientID);

			foreach (DataRow row in dtPatientID.Rows)
			{
				if (row["passport_num"].ToString() == Constants.UserPassport)
				{
					patient_id = Convert.ToInt32(row["patient_id"]);
				}
			}

			var dateText = cbDate.Text.Replace(" ", "");
			var parseDate = dateText.Split(',');
			string dateString = parseDate[0] + '-' + SupFuncs.MonthToInt(parseDate[1]) + '-' + parseDate[2] + "T" + cbTime.Text + ":00";

			DateTime dateTime = DateTime.Parse(dateString);
			strSQL = String.Format("INSERT INTO Orders (patient_id, doctor_id, date, os_id) VALUES ({0}, {1}, '{2}', 1)",  patient_id, doctor_id, dateString);
			OleDbCommand command = new OleDbCommand(strSQL, Constants.cn);
			command.ExecuteNonQuery();
			//2022-12-19 16:00:00.000


			OF.Close();
			OrdersForm of = new OrdersForm();
			of.Show();
		}

		private void cbDoctorSpec_SelectedIndexChanged(object sender, EventArgs e)
		{
			labelDoctorName.Visible = true;
			cbDoctorName.Visible = true;
			System.Windows.Forms.ComboBox comboBox = (System.Windows.Forms.ComboBox)sender;
			cbDoctorName.Items.Clear();
			cbDoctorName.Text = "";

			string selectedSpec = (string)cbDoctorSpec.SelectedItem;

			//Doctors ComboBox

			DataTable dtNames = new DataTable();
			string strSQL = String.Format("SELECT d.first_name, d.last_name, s.spec_name\r\nFROM Doctors AS d\r\nINNER JOIN DoctorSpecializations as ds ON ds.doctor_id = d.doctor_id\r\nINNER JOIN Specializations as s ON s.spec_id = ds.spec_id\r\nWHERE s.spec_name = '{0}'", cbDoctorSpec.Text);
			OleDbDataAdapter dAdapterSpecs = new OleDbDataAdapter(strSQL, Constants.cn);
			dAdapterSpecs.Fill(dtNames);

			foreach (DataRow row in dtNames.Rows)
			{
				cbDoctorName.Items.Add(row["first_name"].ToString() + " " + row["last_name"].ToString());
			}
		}

		private void cbDate_SelectedIndexChanged(object sender, EventArgs e)
		{
			labelTime.Visible = true;
			cbTime.Visible = true;
			System.Windows.Forms.ComboBox comboBox = (System.Windows.Forms.ComboBox)sender;
			cbTime.Items.Clear();
			cbTime.Text = "";

			string selectedSpec = (string)cbDoctorSpec.SelectedItem;

			string dName = (string)cbDoctorName.Text.Split(' ')[0];
			string dLastName = (string)cbDoctorName.Text.Split(' ')[1];
			DataTable dtOrders = new DataTable();

			var dateText = cbDate.Text.Replace(" ", "");
			var parseDate = dateText.Split(',');
			string dateString = parseDate[0] + '-' + SupFuncs.MonthToInt(parseDate[1]) + '-' + parseDate[2];
			string strSQL = String.Format("SELECT d.first_name, d.last_name, o.date\r\nFROM Doctors AS d\r\nINNER JOIN Orders as o ON o.doctor_id = d.doctor_id\r\n" +
				"WHERE CONVERT(VARCHAR(25), o.date, 126) LIKE '{0}%' AND d.first_name = '{1}' AND d.last_name = '{2}'", dateString, dName, dLastName);
			OleDbDataAdapter dAdapterOrders = new OleDbDataAdapter(strSQL, Constants.cn);
			dAdapterOrders.Fill(dtOrders);

			List<string> times = new List<string>();
			foreach(DataRow row in dtOrders.Rows)
			{
				DateTime time = DateTime.Parse(row["date"].ToString());
				times.Add(time.TimeOfDay.Hours + ":00");
			}

			//TODO Удалить то время где у врача есть заказы
			var tmp = new DateTime(2022, 12, 1, 9, 0, 0);
			List<string> timesAll = new List<string>();
			for (int i = 0; i < 8; ++i)
			{
				var time = tmp.AddHours(i);
				timesAll.Add(time.TimeOfDay.Hours + ":00");
			}

			var resultTimes = timesAll.Except(times);

			cbTime.Items.AddRange(resultTimes.ToArray());
		}

		private void cbDoctorName_SelectedIndexChanged(object sender, EventArgs e)
		{
			labelDate.Visible = true;
			cbDate.Visible = true;
			cbDate.Items.Clear();
			cbDate.Text = "";

			var tmp = DateTime.Now;
			for (int i = 1; i < 31; ++i)
			{
				var date = tmp.AddDays(i);
				cbDate.Items.Add(date.Year + ", " + SupFuncs.GetMonthFromInt(date.Month) + ", " + date.Day);
			}
		}
	}
}
