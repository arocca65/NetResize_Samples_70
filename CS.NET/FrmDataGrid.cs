using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Softgroup
{
	public partial class FrmDataGrid
	{


		internal FrmDataGrid()
		{
			InitializeComponent();
		}
		private void FrmDataGrid_Load(object sender, System.EventArgs e)
		{

			//Sets NetResize Licenses Informations
			//With Me.NetResize1
			//    .LicenseName = "your license name or company name"
			//    .LicenseUser = "your license user name or email"
			//    .LicenseKey = "your license key"
			//End With

			LoadData();

		}

		private void LoadData()
		{

			string[] Data = new string[6];
			int Row = 0;
			int Col = 0;

			for (Row = 0; Row <= 10; Row++)
			{
				Col = 0;
				Data[Col] = "Row" + Row.ToString() + " Col" + Col.ToString();
				Col = 3;
				Data[Col] = "Row" + Row.ToString() + " Col" + Col.ToString();
				DataGridView1.Rows.Add(Data);
			}

		}

		private void NetResize1_AfterControlResize(System.Windows.Forms.Control oControl, bool bCtrlResized, bool bFontResized)
		{
			this.DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
		}

	}
} //end of root namespace