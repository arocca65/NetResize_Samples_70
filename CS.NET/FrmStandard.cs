using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Softgroup
{
	public partial class FrmStandard
	{

		internal FrmStandard()
		{
			InitializeComponent();
		}
		private void ButNewGrdWnd_Click(object sender, System.EventArgs e)
		{

			FrmDataGrid nForm = new FrmDataGrid();
			nForm.Show();

		}

		private void ButNewMdiWnd_Click(object sender, System.EventArgs e)
		{

			FrmMDI nForm = new FrmMDI();
			nForm.Show();

		}


		private void ButNewStdWnd_Click(object sender, System.EventArgs e)
		{
			FrmStandard nForm = new FrmStandard();
			nForm.Show();
		}

		private void Button3_Click(object sender, System.EventArgs e)
		{
			this.NetResize1.FormCenter();
		}


		private void Button4_Click(object sender, System.EventArgs e)
		{
			this.ListView1.Items.Clear();
			this.ListBox1.Items.Clear();
		}

		private void CenterFormToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			this.NetResize1.FormCenter();
		}

		private void CheckResizeList_CheckedChanged(object sender, System.EventArgs e)
		{

			this.NetResize1.set_ExcludedResize(this.ListView1, NetResize.NetResize.ExcludedResizeEnum.erAll, ! this.CheckResizeList.Checked);
			this.NetResize1.Refresh();

		}

		private void CheckResizeTab_CheckedChanged(object sender, System.EventArgs e)
		{

			this.NetResize1.set_ExcludedResize(this.TabControl1, NetResize.NetResize.ExcludedResizeEnum.erAll, ! this.CheckResizeTab.Checked);
			this.NetResize1.Refresh();

		}

		private void DockLeftToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			this.ToolStrip1.Dock = DockStyle.Top;
            this.toolStrip2.Dock = DockStyle.Top;
			this.NetResize1.Refresh();
		}

		private void DockToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			this.ToolStrip1.Dock = DockStyle.Right;
            this.toolStrip2.Dock = DockStyle.Right;
			this.NetResize1.Refresh();
		}

		private void DockTopToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			this.ToolStrip1.Dock = DockStyle.Left;
            this.toolStrip2.Dock = DockStyle.Left;
			this.NetResize1.Refresh();
		}

		private void ExitToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			this.Close();
			return;
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{

			//You must enter valid Licensing informations (uncomment code below)
			//Softgroup.NetResize.License.LicenseName = "your license name or company name"
			//Softgroup.NetResize.License.LicenseUser = "your license user name or email"
			//Softgroup.NetResize.License.LicenseKey = "your license key "

			//Custom Resize Properties  (Grid Column With)
			this.NetResize1.AddControlPropertyWidth(this.ListView1, "Columns(0).Width");
			//Code below disable resize the form to a size smaller than design-time size (stretch  and shrink)
			this.NetResize1.MinimumSize = new System.Drawing.Size(this.NetResize1.OriginalFormWidth, this.NetResize1.OriginalFormHeight);

		}


		private void LinkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process oProcess = new System.Diagnostics.Process();
			oProcess.StartInfo.FileName = "http://www.soft-group.it/net";
			oProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
			oProcess.Start();
		}

		private void MaximizeToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			this.WindowState = FormWindowState.Maximized;
		}

		private void MinimizeToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void MinimumSizeToolStripMenuItem_Click(object sender, System.EventArgs e)
		{

			if (MinimumSizeToolStripMenuItem.Checked)
			{
				this.NetResize1.MinimumSize = new System.Drawing.Size(this.NetResize1.OriginalFormWidth, this.NetResize1.OriginalFormHeight);
			}
			else
			{
				this.NetResize1.MinimumSize = new System.Drawing.Size(0, 0);
			}

		}

		private void MnuNewGrdWin_Click(object sender, System.EventArgs e)
		{

			FrmDataGrid nForm = new FrmDataGrid();
			nForm.Show();

		}

		private void MnuNewMdiWin_Click(object sender, System.EventArgs e)
		{

			FrmMDI nForm = new FrmMDI();
			nForm.Show();

		}

		private void MnuNewStdWin_Click(object sender, System.EventArgs e)
		{

			FrmStandard nForm = new FrmStandard();
			nForm.Show();

		}


        private void NetResize1_AfterControlResize(object sender, Softgroup.NetResize.AfterControlResizeEventArgs e)
        {
            if (this.AddResizeEventsToListViewToolStripMenuItem.Checked)
            {
                this.ListBox1.Items.Add(e.Control.Name + " " + e.CtrlResize.ToString() + " " + e.FontResize.ToString());
            }
        }



        private void NetResize1_BeforeControlResize(object sender, Softgroup.NetResize.BeforeControlResizeEventArgs e)
        {
            if (this.AddResizeEventsToListViewToolStripMenuItem.Checked)
            {
                ListViewItem oItem = null;
                oItem = this.ListView1.Items.Add(e.Control.Name);
                oItem.SubItems.Add(e.Control.Left.ToString());
                oItem.SubItems.Add(e.Control.Top.ToString());
                oItem.SubItems.Add(e.Control.Width.ToString());
                oItem.SubItems.Add(e.Control.Height.ToString());
                if (e.Control.Font != null)
                {
                    oItem.SubItems.Add(e.Control.Font.Size.ToString());
                }
            }
        }

        private void NetResize1_BeforeFormResize(object sender, System.EventArgs e)
		{
			if (this.AddResizeEventsToListViewToolStripMenuItem.Checked)
			{
				this.ListBox1.Items.Clear();
			}
		}

		private void RestoreOriginalSizeToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			this.NetResize1.FormRestore();
		}

		private void FadeEffectToolStripMenuItem_Click(object sender, System.EventArgs e)
		{

			this.NetResize1.FormFadeOut();
			this.NetResize1.FormFadeIn();

		}

		private void ResizeEnabledToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			this.NetResize1.Enabled = ResizeEnabledToolStripMenuItem.Checked;
		}

		private void AddingControlsToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			FrmRuntime fRuntime = new FrmRuntime();
			fRuntime.Show(this);
		}

		private void DPIAutoResizeToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			NetResize1.DPIAutoResize = ! NetResize1.DPIAutoResize;
			DPIAutoResizeToolStripMenuItem.Checked = NetResize1.DPIAutoResize;
			MessageBox.Show("This form will be designed at 96 DPI resolution. To see DPIAutoResize property in action you must change system DPI resolution and restart this sample application.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}


} //end of root namespace