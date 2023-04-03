using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Softgroup
{
	public partial class FrmRuntime : System.Windows.Forms.Form
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
			this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
			this.FormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AddControlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.RestoreFormToOriginalSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.NetResize1 = new Softgroup.NetResize.NetResize(this.components);
			this.MenuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.NetResize1).BeginInit();
			this.SuspendLayout();
			//
			//MenuStrip1
			//
			this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.FormToolStripMenuItem});
			this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
			this.MenuStrip1.Name = "MenuStrip1";
			this.MenuStrip1.Size = new System.Drawing.Size(226, 24);
			this.MenuStrip1.TabIndex = 0;
			this.MenuStrip1.Text = "MenuStrip1";
			//
			//FormToolStripMenuItem
			//
			this.FormToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.AddControlsToolStripMenuItem, this.ToolStripSeparator1, this.RestoreFormToOriginalSizeToolStripMenuItem, this.ToolStripSeparator2, this.ExitToolStripMenuItem});
			this.FormToolStripMenuItem.Name = "FormToolStripMenuItem";
			this.FormToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.FormToolStripMenuItem.Text = "&Form";
			//
			//AddControlsToolStripMenuItem
			//
			this.AddControlsToolStripMenuItem.Name = "AddControlsToolStripMenuItem";
			this.AddControlsToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
			this.AddControlsToolStripMenuItem.Text = "Add Controls";
			//
			//ToolStripSeparator1
			//
			this.ToolStripSeparator1.Name = "ToolStripSeparator1";
			this.ToolStripSeparator1.Size = new System.Drawing.Size(221, 6);
			//
			//RestoreFormToOriginalSizeToolStripMenuItem
			//
			this.RestoreFormToOriginalSizeToolStripMenuItem.Name = "RestoreFormToOriginalSizeToolStripMenuItem";
			this.RestoreFormToOriginalSizeToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
			this.RestoreFormToOriginalSizeToolStripMenuItem.Text = "&Restore Form to Original Size";
			//
			//ToolStripSeparator2
			//
			this.ToolStripSeparator2.Name = "ToolStripSeparator2";
			this.ToolStripSeparator2.Size = new System.Drawing.Size(221, 6);
			//
			//ExitToolStripMenuItem
			//
			this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
			this.ExitToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
			this.ExitToolStripMenuItem.Text = "&Exit";
			//
			//NetResize1
			//
			this.NetResize1.ParentControl = this;
			//
			//FrmRuntime
			//
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(226, 177);
			this.Controls.Add(this.MenuStrip1);
			this.MainMenuStrip = this.MenuStrip1;
			this.Name = "FrmRuntime";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Adding controls at run-time sample";
			this.MenuStrip1.ResumeLayout(false);
			this.MenuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.NetResize1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

			this.Shown += new System.EventHandler(FrmRuntime_Shown);
			RestoreFormToOriginalSizeToolStripMenuItem.Click += new System.EventHandler(RestoreFormToOriginalSizeToolStripMenuItem_Click);
			ExitToolStripMenuItem.Click += new System.EventHandler(ExitToolStripMenuItem_Click);
			AddControlsToolStripMenuItem.Click += new System.EventHandler(AddControlsToolStripMenuItem_Click);

		}
		internal System.Windows.Forms.MenuStrip MenuStrip1;
		internal System.Windows.Forms.ToolStripMenuItem FormToolStripMenuItem;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
		internal System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
		internal Softgroup.NetResize.NetResize NetResize1;
		internal System.Windows.Forms.ToolStripMenuItem AddControlsToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem RestoreFormToOriginalSizeToolStripMenuItem;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
	}

} //end of root namespace