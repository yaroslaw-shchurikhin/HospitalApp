using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalApp.Model;

namespace HospitalApp.SupportFuncs
{
	public class StoredProcedures
	{
		static public void AddPatient(OleDbConnection conn, User user) 
		{
			string temp = null;
			if (user.DateOfBirth != "--")
			{
				temp = user.DateOfBirth;
			}

			String strSQL = String.Format("exec Add_Patient @Passport = '{0}', " +
				"@Name = '{1}', " +
				"@LastName = '{2}', @Patronymic = '{3}', @DateOfBirth = '{4}', @Phone = '{5}', @Email = '{6}', @Address = '{7}', @Password = '{8}'",
				user.PassportNum, user.Name, user.LastName, user.Patronymic, temp, user.Phone, user.Email, user.Address, user.Password);

			OleDbCommand cmdIC = new OleDbCommand(strSQL, conn);

			try
			{
				int c = cmdIC.ExecuteNonQuery();

				if (c == -1)
				{
					MessageBox.Show("Операция не была выполнена, так как такой номер паспорта уже существует", "Внимание!", MessageBoxButtons.OK);
				}
				conn.Close();
				Application.Restart();
			}
			catch (OleDbException exc)
			{
				MessageBox.Show(exc.ToString());
			}

		}

		static public void AddNewItemToStorage(OleDbConnection conn, int sup_id, int med_id, int unit_price, int quantity)
		{
			string strSQL = String.Format(@"exec AddItemToStorage @supID = {0}, @medID = {1}, @unit_price = {2}, @quantity = {3})", sup_id, med_id, unit_price, quantity);
			OleDbCommand cmdIC = new OleDbCommand(strSQL, Constants.cn);

			try
			{
				cmdIC.ExecuteNonQuery();
			}
			catch (OleDbException exc)
			{
				MessageBox.Show(exc.ToString());
			}

		}

		static public void AddDoctor(OleDbConnection conn, User user, List<string> specs, int pos_id)
		{

			String strSQL = String.Format("exec Add_Doctor @Passport = '{0}', " +
				"@Name = '{1}', " +
				"@LastName = '{2}', @Patronymic = '{3}', @Phone = '{4}', @Password = '{5}', @PosID = '{6}'",
				user.PassportNum, user.Name, user.LastName, user.Patronymic, user.Phone, user.Password, pos_id);

			OleDbCommand cmdIC = new OleDbCommand(strSQL, conn);

			try
			{
				int c = cmdIC.ExecuteNonQuery();

				if (c == -1)
				{
					MessageBox.Show("Операция не была выполнена, так как такой номер паспорта уже существует", "Внимание!", MessageBoxButtons.OK);
				}
				return;
			}
			catch (OleDbException exc)
			{
				MessageBox.Show(exc.ToString());
			}

			int doctor_id = 0;
			OleDbCommand IDS = new OleDbCommand(String.Format("SELECT doctor_id FROM Doctors WHERE passport_num = '{0}'", user.PassportNum), Constants.cn);
			OleDbDataReader rdr = IDS.ExecuteReader();

			while (rdr.Read())
			{
				doctor_id = Convert.ToInt32(rdr["doctor_id"]);
			}
			rdr.Close();

			int spec_id = 0;
			foreach (string spec in specs)
			{
				IDS = new OleDbCommand(String.Format("SELECT spec_id FROM Specializations WHERE spec_name = '{0}'",spec), Constants.cn);
				rdr = IDS.ExecuteReader();

				while (rdr.Read())
				{
					spec_id = Convert.ToInt32(rdr["spec_id"]);
				}
				rdr.Close();

				strSQL = String.Format("INSERT INTO DoctorSpecializations (doctor_id, spec_id) VALUES ({0}, {1})", doctor_id, spec_id);

				OleDbCommand cmdspec = new OleDbCommand(strSQL, conn);
				cmdspec.ExecuteNonQuery();
			}
		}

		static public void AddSupplier(OleDbConnection conn, string sup_name, int password_hash, string passport)
		{
			String strSQL = String.Format("exec Add_Supplier @Passport = '{0}', " +
				"@Name = '{1}', " +
				"@Password = '{2}'", passport, sup_name, password_hash);

			OleDbCommand cmdIC = new OleDbCommand(strSQL, conn);

			try
			{
				int c = cmdIC.ExecuteNonQuery();

				if (c == -1)
				{
					MessageBox.Show("Операция не была выполнена, так как такой логин уже существует", "Внимание!", MessageBoxButtons.OK);
				}
			}
			catch (OleDbException exc)
			{
				MessageBox.Show(exc.ToString());
			}

		}

		static public void DeleteSupplier(OleDbConnection conn, string sup_name)
		{
			string login = "";
			OleDbCommand IDS = new OleDbCommand(String.Format("SELECT passport_num FROM Suppliers WHERE sup_name = '{0}'", sup_name), Constants.cn);
			OleDbDataReader rdr = IDS.ExecuteReader();

			while (rdr.Read())
			{
				login = rdr["passport_num"].ToString();
			}

			rdr.Close();

			String strSQL = String.Format("exec Delete_supplier @Passport = '{0}'", login);

			OleDbCommand cmdIC = new OleDbCommand(strSQL, conn);

			try
			{
				int c = cmdIC.ExecuteNonQuery();

				if(c == -1)
				{
					MessageBox.Show("Операция не была выполнена, так как у поставщика есть незавершённые заказы", "Внимание!", MessageBoxButtons.OK);
				}
			}
			catch (OleDbException exc)
			{
				MessageBox.Show(exc.ToString());
			}

		}
	}
}
