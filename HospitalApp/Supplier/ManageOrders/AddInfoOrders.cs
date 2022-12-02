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

namespace HospitalApp.Supplier.ManageOrders
{
	public partial class AddInfoOrders : Form
	{
		BindingSource bs = new BindingSource();
		public AddInfoOrders(int ots_id)
		{
			InitializeComponent();

			DataTable dtTmp = new DataTable();
			String strSQL = String.Format(@"SELECT otsd.ots_id,m.name, otsd.unit_price, otsd.quantity, otsd.discount 
				FROM OrdersToSuppliersDetails AS otsd
				INNER JOIN Medicines AS m ON m.med_id = otsd.med_id
				WHERE otsd.ots_id = '{0}'
				GROUP BY  otsd.ots_id, m.name, otsd.unit_price, otsd.quantity, otsd.discount", ots_id);

			OleDbDataAdapter dAdapter = new OleDbDataAdapter(strSQL, Constants.cn);
			dAdapter.Fill(dtTmp);
			bs.DataSource = dtTmp;
			dgAddInfoOrder.DataSource = bs;
			dgAddInfoOrder.AutoSizeColumnsMode =
					 DataGridViewAutoSizeColumnsMode.AllCells;
		}
	}
}
