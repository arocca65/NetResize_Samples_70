using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Softgroup
{
	public partial class FrmRuntime
	{


		internal FrmRuntime()
		{
			InitializeComponent();
		}
		private void AddControlsToolStripMenuItem_Click(object sender, System.EventArgs e)
		{

			System.Windows.Forms.Label oLabel1 = new System.Windows.Forms.Label();
			System.Windows.Forms.TextBox oTextBox1 = new System.Windows.Forms.TextBox();
			System.Windows.Forms.Panel oPanel1 = new System.Windows.Forms.Panel();
			System.Windows.Forms.Label oLabel2 = new System.Windows.Forms.Label();
			System.Windows.Forms.TextBox oTextBox2 = new System.Windows.Forms.TextBox();

			//Label1
			oLabel1.AutoEllipsis = true;
			oLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			oLabel1.Location = new System.Drawing.Point(12, 37);
			oLabel1.Name = "Label1";
			oLabel1.Size = new System.Drawing.Size(100, 22);
			oLabel1.TabIndex = 1;
			oLabel1.Text = "Sample Label";
			oLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//TextBox1
			oTextBox1.Location = new System.Drawing.Point(118, 39);
			oTextBox1.Name = "TextBox1";
			oTextBox1.Size = new System.Drawing.Size(100, 20);
			oTextBox1.TabIndex = 2;
			oTextBox1.Text = "Sample Text";
			//Panel1
			oPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			oPanel1.Location = new System.Drawing.Point(12, 65);
			oPanel1.Name = "Panel1";
			oPanel1.Size = new System.Drawing.Size(206, 105);
			oPanel1.TabIndex = 3;
			//Label2
			oLabel2.AutoEllipsis = true;
			oLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			oLabel2.Location = new System.Drawing.Point(8, 9);
			oLabel2.Name = "Label2";
			oLabel2.Size = new System.Drawing.Size(187, 22);
			oLabel2.TabIndex = 2;
			oLabel2.Text = "Sample Label 2";
			oLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//TextBox2
			oTextBox2.Location = new System.Drawing.Point(8, 43);
			oTextBox2.Multiline = true;
			oTextBox2.Name = "TextBox2";
			oTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			oTextBox2.Size = new System.Drawing.Size(187, 50);
			oTextBox2.TabIndex = 3;
			oTextBox2.Text = "Line 1" + "\r" + "\n" + "Line 2" + "\r" + "\n" + "Line 3" + "\r" + "\n";

			this.Controls.Add(oLabel1);
			this.Controls.Add(oTextBox1);
			oPanel1.Controls.Add(oTextBox2);
			oPanel1.Controls.Add(oLabel2);
			this.Controls.Add(oPanel1);

			this.AddControlsToolStripMenuItem.Enabled = false;

		}

		private void ExitToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void RestoreFormToOriginalSizeToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			this.NetResize1.FormRestore();
		}

		private void FrmRuntime_Shown(object sender, System.EventArgs e)
		{
			MessageBox.Show("Please click on Add Controls and then try to resize form or ... " + System.Environment.NewLine + "You can also resize form before adding controls.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

	}
} //end of root namespace