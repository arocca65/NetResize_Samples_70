using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Softgroup
{
	public partial class FrmDataGrid : System.Windows.Forms.Form
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
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.DataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewLinkColumn();
			this.NetResize1 = new Softgroup.NetResize.NetResize(this.components);
			((System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.NetResize1).BeginInit();
			this.SuspendLayout();
			//
			//DataGridView1
			//
			this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.Column1, this.Column3, this.Column4, this.Column6});
			DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			DataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3;
			this.DataGridView1.Location = new System.Drawing.Point(12, 10);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.Size = new System.Drawing.Size(423, 301);
			this.DataGridView1.TabIndex = 0;
			//
			//Column1
			//
			this.Column1.HeaderText = "Column1";
			this.Column1.Name = "Column1";
			//
			//Column3
			//
			this.Column3.HeaderText = "Column3";
			this.Column3.Name = "Column3";
			//
			//Column4
			//
			this.Column4.HeaderText = "Column4";
			this.Column4.Name = "Column4";
			//
			//Column6
			//
			this.Column6.HeaderText = "Column6";
			this.Column6.Name = "Column6";
			//
			//NetResize1
			//
			this.NetResize1.DataGridViewAutoResize = true;
			this.NetResize1.ParentControl = this;
			//
			//FrmDataGrid
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float)(6.0), (float)(13.0));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(447, 323);
			this.Controls.Add(this.DataGridView1);
			this.Name = "FrmDataGrid";
			this.Text = ".Net Forms Resize Sample (Data Grid Window)";
			((System.ComponentModel.ISupportInitialize)this.DataGridView1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.NetResize1).EndInit();
			this.ResumeLayout(false);

			this.Load += new System.EventHandler(FrmDataGrid_Load);

		}
		internal System.Windows.Forms.ToolTip ToolTip1;
		internal System.Windows.Forms.DataGridView DataGridView1;
		internal System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		internal System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
		internal System.Windows.Forms.DataGridViewComboBoxColumn Column4;
		internal System.Windows.Forms.DataGridViewLinkColumn Column6;
		internal Softgroup.NetResize.NetResize NetResize1;
	}

} //end of root namespace