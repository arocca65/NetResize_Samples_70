using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Softgroup
{
	public partial class FrmMDI : System.Windows.Forms.Form
	{

		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}


		private System.ComponentModel.IContainer components;

		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
			this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.NewWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.NewWindowBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuStrip1.SuspendLayout();
			this.SuspendLayout();
			//
			//MenuStrip1
			//
			this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.FileToolStripMenuItem});
			this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
			this.MenuStrip1.Name = "MenuStrip1";
			this.MenuStrip1.Size = new System.Drawing.Size(632, 24);
			this.MenuStrip1.TabIndex = 9;
			this.MenuStrip1.Text = "MenuStrip1";
			//
			//FileToolStripMenuItem
			//
			this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.NewWindowToolStripMenuItem, this.NewWindowBToolStripMenuItem});
			this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
			this.FileToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
			this.FileToolStripMenuItem.Text = "&Show";
			//
			//NewWindowToolStripMenuItem
			//
			this.NewWindowToolStripMenuItem.Name = "NewWindowToolStripMenuItem";
			this.NewWindowToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
			this.NewWindowToolStripMenuItem.Text = "New Child Standard Window";
			//
			//NewWindowBToolStripMenuItem
			//
			this.NewWindowBToolStripMenuItem.Name = "NewWindowBToolStripMenuItem";
			this.NewWindowBToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
			this.NewWindowBToolStripMenuItem.Text = "New Child Grid Window ";
			//
			//FrmMDI
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float)(6.0), (float)(13.0));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(632, 453);
			this.Controls.Add(this.MenuStrip1);
			this.IsMdiContainer = true;
			this.Name = "FrmMDI";
			this.Text = ".Net Forms Resize Sample (MDI Window)";
			this.MenuStrip1.ResumeLayout(false);
			this.MenuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

			NewWindowBToolStripMenuItem.Click += new System.EventHandler(NewWindowBToolStripMenuItem_Click);
			NewWindowToolStripMenuItem.Click += new System.EventHandler(NewWindowToolStripMenuItem_Click);

		}
		internal System.Windows.Forms.ToolTip ToolTip;
		internal System.Windows.Forms.MenuStrip MenuStrip1;
		internal System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem NewWindowToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem NewWindowBToolStripMenuItem;

	}

} //end of root namespace