using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp
{
	internal class Constants
	{
		static int n = 0;
		internal static OleDbConnection cn = new OleDbConnection();

		internal static string UserPassport { get; set; }
	}

}