using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Softgroup
{
	public partial class FrmMDI
	{


		internal FrmMDI()
		{
			InitializeComponent();
		}
		private void NewWindowToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			FrmStandard oChild = new FrmStandard();
			oChild.MdiParent = this;
			oChild.Show();
		}

		private void NewWindowBToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			FrmDataGrid oChild = new FrmDataGrid();
			oChild.MdiParent = this;
			oChild.Show();
		}

	}


} //end of root namespace