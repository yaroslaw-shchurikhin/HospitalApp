using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp.SupportFuncs
{
	public class SupFuncs
	{
		public static DataTable getAccounts(OleDbConnection conn)
		{
			DataTable dt = new DataTable();
			DataSet ds = new DataSet();
			String strSQL = "SELECT * FROM Accounts";

			var dAdapter = new OleDbDataAdapter(strSQL, conn);
			dAdapter.Fill(ds, "Accounts");

			dt = ds.Tables["Accounts"];

			return dt;
		}
		public static int MonthToInt(string month)
		{
			switch (month)
			{
				case "Январь":
					return 1;
					break;
				case "Февраль":
					return 2;
					break;
				case "Март":
					return 3;
				case "Апрель":
					return 4;
					break;
				case "Май":
					return 5;
					break;
				case "Июнь":
					return 6;
					break;
				case "Июль":
					return 7;
					break;
				case "Август":
					return 8;
					break;
				case "Сентябрь":
					return 9;
					break;
				case "Октябрь":
					return 10;
					break;
				case "Ноябрь":
					return 11;
					break;
				case "Декабрь":
					return 12;
					break;
				default:
					return 0;
			}
		}
		public static string GetMonthFromInt(int month)
		{
			string monthName = "";
			switch(month) 
			{ 
			case 1:
					monthName = "Январь";
					break;
				case 2:
					monthName = "Февраль";
					break;
				case 3:
					monthName = "Март";
					break;
				case 4:
					monthName = "Апрель";
					break;
				case 5:
					monthName = "Май";
					break;
				case 6:
					monthName = "Июнь";
					break;
				case 7:
					monthName = "Июль";
					break;
				case 8:
					monthName = "Август";
					break;
				case 9:
					monthName = "Сентябрь";
					break;
				case 10:
					monthName = "Октябрь";
					break;
				case 11:
					monthName = "Ноябрь";
					break;
				case 12:
					monthName = "Декабрь";
					break;
			}

			return monthName;
		}
		public static void DeliverOrder(int ots_id)
		{
			//Изменить статус заказа и добавить его на склад больницы
			String strSQL = String.Format(@"UPDATE OrdersToSuppliers SET status_id = 1 WHERE ots_id = '{0}'", ots_id);
			OleDbCommand cmdIC = new OleDbCommand(strSQL, Constants.cn);
			cmdIC.ExecuteNonQuery();

			// Кладём товар на склад больницы
			DataTable dtTmp = new DataTable();

			strSQL = String.Format(@"SELECT otsd.med_id, otsd.quantity
				FROM OrdersToSuppliersDetails AS otsd
				INNER JOIN OrdersToSuppliers AS ots on ots.ots_id = otsd.ots_id
				WHERE otsd.ots_id = '{0}'", ots_id);

			OleDbDataAdapter dAdapter = new OleDbDataAdapter(strSQL, Constants.cn);
			dAdapter.Fill(dtTmp);

			foreach (DataRow row in dtTmp.Rows)
			{
				var med_id = row["med_id"];
				var quantity = row["quantity"];

				int int_med_id = Convert.ToInt32(med_id);

				strSQL = String.Format(@"UPDATE Medicines SET quantity = quantity + {0} WHERE med_id = '{1}'", Convert.ToInt32(quantity), Convert.ToInt32(med_id));
				cmdIC = new OleDbCommand(strSQL, Constants.cn);
				cmdIC.ExecuteNonQuery();
			}
		}
	}
}
