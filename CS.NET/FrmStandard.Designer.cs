using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Softgroup
{
	public partial class FrmStandard : System.Windows.Forms.Form
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
        		
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Nodo1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Nodo2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Nodo3");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Nodo0", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Nodo5");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Nodo6");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Nodo7");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Nodo8");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Nodo4", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStandard));
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.LinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.RichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.ColumnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ButNewStdWnd = new System.Windows.Forms.ToolStripButton();
            this.ButNewMdiWnd = new System.Windows.Forms.ToolStripButton();
            this.ButNewGrdWnd = new System.Windows.Forms.ToolStripButton();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.WebBrowser1 = new System.Windows.Forms.WebBrowser();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.TreeView1 = new System.Windows.Forms.TreeView();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.CheckedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.CheckBox2 = new System.Windows.Forms.CheckBox();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuNewStdWin = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuNewMdiWin = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuNewGrdWin = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.AddingControlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EffectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FadeEffectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.AddResizeEventsToListViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CenterFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MinimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MaximizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MinimumSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.RestoreOriginalSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ResizeEnabledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.DPIAutoResizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DockLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DockTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.VScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.CheckResizeList = new System.Windows.Forms.CheckBox();
            this.CheckResizeTab = new System.Windows.Forms.CheckBox();
            this.NetResize1 = new Softgroup.NetResize.NetResize(this.components);
            NetResize1.AfterControlResize += new Softgroup.NetResize.NetResize.AfterControlResizeEventHandler(NetResize1_AfterControlResize);
            NetResize1.BeforeControlResize += new Softgroup.NetResize.NetResize.BeforeControlResizeEventHandler(NetResize1_BeforeControlResize);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).BeginInit();
            this.StatusStrip1.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.MenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NetResize1)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboBox1
            // 
            this.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Items.AddRange(new object[] {
            "Item1",
            "Item2",
            "Item3",
            "Item4",
            "Item5"});
            this.ComboBox1.Location = new System.Drawing.Point(343, 261);
            this.ComboBox1.Name = "ComboBox1";
            this.NetResize1.SetResizeChildren(this.ComboBox1, true);
            this.NetResize1.SetResizeControl(this.ComboBox1, true);
            this.NetResize1.SetResizeFont(this.ComboBox1, true);
            this.ComboBox1.Size = new System.Drawing.Size(82, 22);
            this.ComboBox1.TabIndex = 2;
                        // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Location = new System.Drawing.Point(12, 203);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.NetResize1.SetResizeChildren(this.DateTimePicker1, true);
            this.NetResize1.SetResizeControl(this.DateTimePicker1, true);
            this.NetResize1.SetResizeFont(this.DateTimePicker1, true);
            this.DateTimePicker1.Size = new System.Drawing.Size(234, 20);
            this.DateTimePicker1.TabIndex = 4;
            // 
            // LinkLabel1
            // 
            this.LinkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.LinkLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LinkLabel1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabel1.Location = new System.Drawing.Point(252, 404);
            this.LinkLabel1.Name = "LinkLabel1";
            this.NetResize1.SetResizeChildren(this.LinkLabel1, true);
            this.NetResize1.SetResizeControl(this.LinkLabel1, true);
            this.NetResize1.SetResizeFont(this.LinkLabel1, true);
            this.LinkLabel1.Size = new System.Drawing.Size(175, 23);
            this.LinkLabel1.TabIndex = 6;
            this.LinkLabel1.TabStop = true;
            this.LinkLabel1.Text = "Softgroup .Net Components";
            this.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // ListBox1
            // 
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.ItemHeight = 14;
            this.ListBox1.Location = new System.Drawing.Point(12, 322);
            this.ListBox1.Name = "ListBox1";
            this.NetResize1.SetResizeChildren(this.ListBox1, true);
            this.NetResize1.SetResizeControl(this.ListBox1, true);
            this.NetResize1.SetResizeFont(this.ListBox1, true);
            this.ListBox1.Size = new System.Drawing.Size(234, 74);
            this.ListBox1.Sorted = true;
            this.ListBox1.TabIndex = 7;
            this.ToolTip1.SetToolTip(this.ListBox1, "Events");
            // 
            // NumericUpDown1
            // 
            this.NumericUpDown1.Location = new System.Drawing.Point(252, 261);
            this.NumericUpDown1.Name = "NumericUpDown1";
            this.NetResize1.SetResizeChildren(this.NumericUpDown1, true);
            this.NetResize1.SetResizeControl(this.NumericUpDown1, true);
            this.NetResize1.SetResizeFont(this.NumericUpDown1, true);
            this.NumericUpDown1.Size = new System.Drawing.Size(85, 20);
            this.NumericUpDown1.TabIndex = 9;
            // 
            // RichTextBox1
            // 
            this.RichTextBox1.Location = new System.Drawing.Point(12, 230);
            this.RichTextBox1.Name = "RichTextBox1";
            this.NetResize1.SetResizeChildren(this.RichTextBox1, true);
            this.NetResize1.SetResizeControl(this.RichTextBox1, true);
            this.NetResize1.SetResizeFont(this.RichTextBox1, true);
            this.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.RichTextBox1.Size = new System.Drawing.Size(234, 49);
            this.RichTextBox1.TabIndex = 13;
            this.RichTextBox1.Text = "This is a sample\n";
            // 
            // TextBox1
            // 
            this.TextBox1.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox1.Location = new System.Drawing.Point(253, 292);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.NetResize1.SetResizeChildren(this.TextBox1, true);
            this.NetResize1.SetResizeControl(this.TextBox1, true);
            this.NetResize1.SetResizeFont(this.TextBox1, true);
            this.NetResize1.SetResizeTextBoxMultiline(this.TextBox1, false);
            this.TextBox1.Size = new System.Drawing.Size(172, 21);
            this.TextBox1.TabIndex = 14;
            this.TextBox1.Text = "Sample Arial";
            // 
            // TextBox2
            // 
            this.TextBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox2.Location = new System.Drawing.Point(12, 292);
            this.TextBox2.Multiline = true;
            this.TextBox2.Name = "TextBox2";
            this.NetResize1.SetResizeChildren(this.TextBox2, true);
            this.NetResize1.SetResizeControl(this.TextBox2, true);
            this.NetResize1.SetResizeFont(this.TextBox2, true);
            this.NetResize1.SetResizeTextBoxMultiline(this.TextBox2, false);
            this.TextBox2.Size = new System.Drawing.Size(234, 21);
            this.TextBox2.TabIndex = 15;
            this.TextBox2.Text = "Sample Tahoma";
            // 
            // ListView1
            // 
            this.ListView1.BackColor = System.Drawing.Color.AliceBlue;
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader5,
            this.ColumnHeader6,
            this.ColumnHeader7,
            this.ColumnHeader8,
            this.ColumnHeader9,
            this.ColumnHeader10});
            this.ListView1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListView1.Location = new System.Drawing.Point(12, 60);
            this.ListView1.Name = "ListView1";
            this.NetResize1.SetResizeChildren(this.ListView1, true);
            this.NetResize1.SetResizeControl(this.ListView1, true);
            this.NetResize1.SetResizeFont(this.ListView1, true);
            this.ListView1.Size = new System.Drawing.Size(413, 138);
            this.ListView1.TabIndex = 16;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader5
            // 
            this.ColumnHeader5.Text = "Control";
            // 
            // ColumnHeader6
            // 
            this.ColumnHeader6.Text = "Left";
            // 
            // ColumnHeader7
            // 
            this.ColumnHeader7.Text = "Top";
            // 
            // ColumnHeader8
            // 
            this.ColumnHeader8.Text = "Width";
            // 
            // ColumnHeader9
            // 
            this.ColumnHeader9.Text = "Height";
            // 
            // ColumnHeader10
            // 
            this.ColumnHeader10.Text = "FontSize";
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel1});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 434);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.NetResize1.SetResizeChildren(this.StatusStrip1, true);
            this.NetResize1.SetResizeControl(this.StatusStrip1, true);
            this.NetResize1.SetResizeFont(this.StatusStrip1, true);
            this.StatusStrip1.Size = new System.Drawing.Size(699, 22);
            this.StatusStrip1.TabIndex = 17;
            this.StatusStrip1.Text = ".Net Forms Resize Demo";
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(684, 17);
            this.ToolStripStatusLabel1.Spring = true;
            this.ToolStripStatusLabel1.Text = ".Net Forms Resize Demo";
            this.ToolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButNewStdWnd,
            this.ButNewMdiWnd,
            this.ButNewGrdWnd});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 24);
            this.ToolStrip1.Name = "ToolStrip1";
            this.NetResize1.SetResizeChildren(this.ToolStrip1, true);
            this.NetResize1.SetResizeControl(this.ToolStrip1, true);
            this.NetResize1.SetResizeFont(this.ToolStrip1, true);
            this.ToolStrip1.Size = new System.Drawing.Size(699, 25);
            this.ToolStrip1.TabIndex = 18;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // ButNewStdWnd
            // 
            this.ButNewStdWnd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButNewStdWnd.Image = ((System.Drawing.Image)(resources.GetObject("ButNewStdWnd.Image")));
            this.ButNewStdWnd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButNewStdWnd.Name = "ButNewStdWnd";
            this.ButNewStdWnd.Size = new System.Drawing.Size(23, 22);
            this.ButNewStdWnd.ToolTipText = "New Standard Window";
            this.ButNewStdWnd.Click += new System.EventHandler(this.ButNewStdWnd_Click);
            // 
            // ButNewMdiWnd
            // 
            this.ButNewMdiWnd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButNewMdiWnd.Image = ((System.Drawing.Image)(resources.GetObject("ButNewMdiWnd.Image")));
            this.ButNewMdiWnd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButNewMdiWnd.Name = "ButNewMdiWnd";
            this.ButNewMdiWnd.Size = new System.Drawing.Size(23, 22);
            this.ButNewMdiWnd.ToolTipText = "New MDI Window";
            this.ButNewMdiWnd.Click += new System.EventHandler(this.ButNewMdiWnd_Click);
            // 
            // ButNewGrdWnd
            // 
            this.ButNewGrdWnd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButNewGrdWnd.Image = ((System.Drawing.Image)(resources.GetObject("ButNewGrdWnd.Image")));
            this.ButNewGrdWnd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButNewGrdWnd.Name = "ButNewGrdWnd";
            this.ButNewGrdWnd.Size = new System.Drawing.Size(23, 22);
            this.ButNewGrdWnd.ToolTipText = "New Data Grid Window";
            this.ButNewGrdWnd.Click += new System.EventHandler(this.ButNewGrdWnd_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.RadioButton2);
            this.GroupBox1.Controls.Add(this.RadioButton1);
            this.GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.GroupBox1.Location = new System.Drawing.Point(253, 322);
            this.GroupBox1.Name = "GroupBox1";
            this.NetResize1.SetResizeChildren(this.GroupBox1, true);
            this.NetResize1.SetResizeControl(this.GroupBox1, true);
            this.NetResize1.SetResizeFont(this.GroupBox1, true);
            this.GroupBox1.Size = new System.Drawing.Size(172, 76);
            this.GroupBox1.TabIndex = 19;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "GroupBox1";
            // 
            // RadioButton2
            // 
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.BackColor = System.Drawing.Color.Transparent;
            this.RadioButton2.Location = new System.Drawing.Point(12, 52);
            this.RadioButton2.Name = "RadioButton2";
            this.NetResize1.SetResizeChildren(this.RadioButton2, true);
            this.NetResize1.SetResizeControl(this.RadioButton2, true);
            this.NetResize1.SetResizeFont(this.RadioButton2, true);
            this.RadioButton2.Size = new System.Drawing.Size(89, 18);
            this.RadioButton2.TabIndex = 14;
            this.RadioButton2.TabStop = true;
            this.RadioButton2.Text = "RadioButton2";
            this.RadioButton2.UseVisualStyleBackColor = false;
            // 
            // RadioButton1
            // 
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.BackColor = System.Drawing.Color.Transparent;
            this.RadioButton1.Location = new System.Drawing.Point(12, 27);
            this.RadioButton1.Name = "RadioButton1";
            this.NetResize1.SetResizeChildren(this.RadioButton1, true);
            this.NetResize1.SetResizeControl(this.RadioButton1, true);
            this.NetResize1.SetResizeFont(this.RadioButton1, true);
            this.RadioButton1.Size = new System.Drawing.Size(89, 18);
            this.RadioButton1.TabIndex = 13;
            this.RadioButton1.TabStop = true;
            this.RadioButton1.Text = "RadioButton1";
            this.RadioButton1.UseVisualStyleBackColor = false;
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl1.Location = new System.Drawing.Point(434, 60);
            this.TabControl1.Name = "TabControl1";
            this.NetResize1.SetResizeChildren(this.TabControl1, true);
            this.NetResize1.SetResizeControl(this.TabControl1, true);
            this.NetResize1.SetResizeFont(this.TabControl1, true);
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(233, 365);
            this.TabControl1.TabIndex = 20;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.WebBrowser1);
            this.TabPage1.Location = new System.Drawing.Point(4, 23);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.NetResize1.SetResizeChildren(this.TabPage1, true);
            this.NetResize1.SetResizeControl(this.TabPage1, true);
            this.NetResize1.SetResizeFont(this.TabPage1, true);
            this.TabPage1.Size = new System.Drawing.Size(225, 338);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "TabPage1";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // WebBrowser1
            // 
            this.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebBrowser1.Location = new System.Drawing.Point(3, 3);
            this.WebBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebBrowser1.Name = "WebBrowser1";
            this.NetResize1.SetResizeChildren(this.WebBrowser1, true);
            this.NetResize1.SetResizeControl(this.WebBrowser1, true);
            this.NetResize1.SetResizeFont(this.WebBrowser1, true);
            this.WebBrowser1.ScriptErrorsSuppressed = true;
            this.WebBrowser1.Size = new System.Drawing.Size(219, 332);
            this.WebBrowser1.TabIndex = 22;
            this.WebBrowser1.Url = new System.Uri("http://www.netresize.net", System.UriKind.Absolute);
            this.WebBrowser1.WebBrowserShortcutsEnabled = false;
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.TreeView1);
            this.TabPage2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPage2.Location = new System.Drawing.Point(4, 23);
            this.TabPage2.Name = "TabPage2";
            this.NetResize1.SetResizeChildren(this.TabPage2, true);
            this.NetResize1.SetResizeControl(this.TabPage2, true);
            this.NetResize1.SetResizeFont(this.TabPage2, true);
            this.TabPage2.Size = new System.Drawing.Size(225, 338);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "TabPage2";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // TreeView1
            // 
            this.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeView1.Location = new System.Drawing.Point(0, 0);
            this.TreeView1.Name = "TreeView1";
            treeNode1.Name = "Nodo1";
            treeNode1.Text = "Nodo1";
            treeNode2.Name = "Nodo2";
            treeNode2.Text = "Nodo2";
            treeNode3.Name = "Nodo3";
            treeNode3.Text = "Nodo3";
            treeNode4.Name = "Nodo0";
            treeNode4.Text = "Nodo0";
            treeNode5.Name = "Nodo5";
            treeNode5.Text = "Nodo5";
            treeNode6.Name = "Nodo6";
            treeNode6.Text = "Nodo6";
            treeNode7.Name = "Nodo7";
            treeNode7.Text = "Nodo7";
            treeNode8.Name = "Nodo8";
            treeNode8.Text = "Nodo8";
            treeNode9.Name = "Nodo4";
            treeNode9.Text = "Nodo4";
            this.TreeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode9});
            this.NetResize1.SetResizeChildren(this.TreeView1, true);
            this.NetResize1.SetResizeControl(this.TreeView1, true);
            this.NetResize1.SetResizeFont(this.TreeView1, true);
            this.TreeView1.Size = new System.Drawing.Size(225, 338);
            this.TreeView1.TabIndex = 1;
            // 
            // TabPage3
            // 
            this.TabPage3.Controls.Add(this.toolStrip2);
            this.TabPage3.Controls.Add(this.CheckedListBox1);
            this.TabPage3.Controls.Add(this.CheckBox2);
            this.TabPage3.Controls.Add(this.Button3);
            this.TabPage3.Location = new System.Drawing.Point(4, 23);
            this.TabPage3.Margin = new System.Windows.Forms.Padding(50);
            this.TabPage3.Name = "TabPage3";
            this.NetResize1.SetResizeChildren(this.TabPage3, true);
            this.NetResize1.SetResizeControl(this.TabPage3, true);
            this.NetResize1.SetResizeFont(this.TabPage3, true);
            this.TabPage3.Size = new System.Drawing.Size(225, 338);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "TabPage3";
            this.TabPage3.UseVisualStyleBackColor = true;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.NetResize1.SetResizeChildren(this.toolStrip2, true);
            this.NetResize1.SetResizeControl(this.toolStrip2, true);
            this.NetResize1.SetResizeFont(this.toolStrip2, true);
            this.toolStrip2.Size = new System.Drawing.Size(225, 25);
            this.toolStrip2.TabIndex = 19;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.ToolTipText = "New Standard Window";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.ToolTipText = "New MDI Window";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.ToolTipText = "New Data Grid Window";
            // 
            // CheckedListBox1
            // 
            this.CheckedListBox1.FormattingEnabled = true;
            this.CheckedListBox1.Items.AddRange(new object[] {
            "Item1",
            "Item2",
            "Item3"});
            this.CheckedListBox1.Location = new System.Drawing.Point(32, 182);
            this.CheckedListBox1.Name = "CheckedListBox1";
            this.NetResize1.SetResizeChildren(this.CheckedListBox1, true);
            this.NetResize1.SetResizeControl(this.CheckedListBox1, true);
            this.NetResize1.SetResizeFont(this.CheckedListBox1, true);
            this.CheckedListBox1.Size = new System.Drawing.Size(154, 109);
            this.CheckedListBox1.TabIndex = 2;
            // 
            // CheckBox2
            // 
            this.CheckBox2.AutoSize = true;
            this.CheckBox2.Location = new System.Drawing.Point(31, 142);
            this.CheckBox2.Name = "CheckBox2";
            this.NetResize1.SetResizeChildren(this.CheckBox2, true);
            this.NetResize1.SetResizeControl(this.CheckBox2, true);
            this.NetResize1.SetResizeFont(this.CheckBox2, true);
            this.CheckBox2.Size = new System.Drawing.Size(81, 18);
            this.CheckBox2.TabIndex = 1;
            this.CheckBox2.Text = "CheckBox2";
            this.CheckBox2.UseVisualStyleBackColor = true;
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(32, 70);
            this.Button3.Name = "Button3";
            this.NetResize1.SetResizeChildren(this.Button3, true);
            this.NetResize1.SetResizeControl(this.Button3, true);
            this.NetResize1.SetResizeFont(this.Button3, true);
            this.Button3.Size = new System.Drawing.Size(161, 32);
            this.Button3.TabIndex = 0;
            this.Button3.Text = "Center Form";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(12, 402);
            this.Button4.Name = "Button4";
            this.NetResize1.SetResizeChildren(this.Button4, true);
            this.NetResize1.SetResizeControl(this.Button4, true);
            this.NetResize1.SetResizeFont(this.Button4, true);
            this.Button4.Size = new System.Drawing.Size(234, 21);
            this.Button4.TabIndex = 21;
            this.Button4.Text = "Clear List";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAToolStripMenuItem,
            this.EffectsToolStripMenuItem,
            this.FormToolStripMenuItem,
            this.ToolbarToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.NetResize1.SetResizeChildren(this.MenuStrip1, true);
            this.NetResize1.SetResizeControl(this.MenuStrip1, true);
            this.NetResize1.SetResizeFont(this.MenuStrip1, true);
            this.MenuStrip1.Size = new System.Drawing.Size(699, 24);
            this.MenuStrip1.TabIndex = 23;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // MenuAToolStripMenuItem
            // 
            this.MenuAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuNewStdWin,
            this.MnuNewMdiWin,
            this.MnuNewGrdWin,
            this.ToolStripSeparator9,
            this.AddingControlsToolStripMenuItem,
            this.ToolStripSeparator1,
            this.ExitToolStripMenuItem});
            this.MenuAToolStripMenuItem.Name = "MenuAToolStripMenuItem";
            this.MenuAToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.MenuAToolStripMenuItem.Text = "&Show";
            // 
            // MnuNewStdWin
            // 
            this.MnuNewStdWin.Name = "MnuNewStdWin";
            this.MnuNewStdWin.Size = new System.Drawing.Size(222, 22);
            this.MnuNewStdWin.Text = "New Standard Window";
            this.MnuNewStdWin.Click += new System.EventHandler(this.MnuNewStdWin_Click);
            // 
            // MnuNewMdiWin
            // 
            this.MnuNewMdiWin.Name = "MnuNewMdiWin";
            this.MnuNewMdiWin.Size = new System.Drawing.Size(222, 22);
            this.MnuNewMdiWin.Text = "New MDI Window";
            this.MnuNewMdiWin.Click += new System.EventHandler(this.MnuNewMdiWin_Click);
            // 
            // MnuNewGrdWin
            // 
            this.MnuNewGrdWin.Name = "MnuNewGrdWin";
            this.MnuNewGrdWin.Size = new System.Drawing.Size(222, 22);
            this.MnuNewGrdWin.Text = "New Data Grid Window";
            this.MnuNewGrdWin.Click += new System.EventHandler(this.MnuNewGrdWin_Click);
            // 
            // ToolStripSeparator9
            // 
            this.ToolStripSeparator9.Name = "ToolStripSeparator9";
            this.ToolStripSeparator9.Size = new System.Drawing.Size(219, 6);
            // 
            // AddingControlsToolStripMenuItem
            // 
            this.AddingControlsToolStripMenuItem.Name = "AddingControlsToolStripMenuItem";
            this.AddingControlsToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.AddingControlsToolStripMenuItem.Text = "Adding controls at run-time";
            this.AddingControlsToolStripMenuItem.Click += new System.EventHandler(this.AddingControlsToolStripMenuItem_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(219, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.ExitToolStripMenuItem.Text = "&Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // EffectsToolStripMenuItem
            // 
            this.EffectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FadeEffectToolStripMenuItem,
            this.ToolStripSeparator8,
            this.AddResizeEventsToListViewToolStripMenuItem});
            this.EffectsToolStripMenuItem.Name = "EffectsToolStripMenuItem";
            this.EffectsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.EffectsToolStripMenuItem.Text = "&Effects";
            // 
            // FadeEffectToolStripMenuItem
            // 
            this.FadeEffectToolStripMenuItem.Name = "FadeEffectToolStripMenuItem";
            this.FadeEffectToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.FadeEffectToolStripMenuItem.Text = "Fade Effect";
            this.FadeEffectToolStripMenuItem.Click += new System.EventHandler(this.FadeEffectToolStripMenuItem_Click);
            // 
            // ToolStripSeparator8
            // 
            this.ToolStripSeparator8.Name = "ToolStripSeparator8";
            this.ToolStripSeparator8.Size = new System.Drawing.Size(225, 6);
            // 
            // AddResizeEventsToListViewToolStripMenuItem
            // 
            this.AddResizeEventsToListViewToolStripMenuItem.Checked = true;
            this.AddResizeEventsToListViewToolStripMenuItem.CheckOnClick = true;
            this.AddResizeEventsToListViewToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AddResizeEventsToListViewToolStripMenuItem.Name = "AddResizeEventsToListViewToolStripMenuItem";
            this.AddResizeEventsToListViewToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.AddResizeEventsToListViewToolStripMenuItem.Text = "Add Resize Events to ListView";
            // 
            // FormToolStripMenuItem
            // 
            this.FormToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CenterFormToolStripMenuItem,
            this.ToolStripSeparator3,
            this.MinimizeToolStripMenuItem,
            this.MaximizeToolStripMenuItem,
            this.ToolStripSeparator2,
            this.MinimumSizeToolStripMenuItem,
            this.ToolStripSeparator5,
            this.RestoreOriginalSizeToolStripMenuItem,
            this.ToolStripSeparator4,
            this.ResizeEnabledToolStripMenuItem,
            this.ToolStripSeparator7,
            this.DPIAutoResizeToolStripMenuItem});
            this.FormToolStripMenuItem.Name = "FormToolStripMenuItem";
            this.FormToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.FormToolStripMenuItem.Text = "&Commands";
            // 
            // CenterFormToolStripMenuItem
            // 
            this.CenterFormToolStripMenuItem.Name = "CenterFormToolStripMenuItem";
            this.CenterFormToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.CenterFormToolStripMenuItem.Text = "Center Window";
            this.CenterFormToolStripMenuItem.Click += new System.EventHandler(this.CenterFormToolStripMenuItem_Click);
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(178, 6);
            // 
            // MinimizeToolStripMenuItem
            // 
            this.MinimizeToolStripMenuItem.Name = "MinimizeToolStripMenuItem";
            this.MinimizeToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.MinimizeToolStripMenuItem.Text = "Minimize Window";
            this.MinimizeToolStripMenuItem.Click += new System.EventHandler(this.MinimizeToolStripMenuItem_Click);
            // 
            // MaximizeToolStripMenuItem
            // 
            this.MaximizeToolStripMenuItem.Name = "MaximizeToolStripMenuItem";
            this.MaximizeToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.MaximizeToolStripMenuItem.Text = "Maximize Window";
            this.MaximizeToolStripMenuItem.Click += new System.EventHandler(this.MaximizeToolStripMenuItem_Click);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(178, 6);
            // 
            // MinimumSizeToolStripMenuItem
            // 
            this.MinimumSizeToolStripMenuItem.Checked = true;
            this.MinimumSizeToolStripMenuItem.CheckOnClick = true;
            this.MinimumSizeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MinimumSizeToolStripMenuItem.Name = "MinimumSizeToolStripMenuItem";
            this.MinimumSizeToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.MinimumSizeToolStripMenuItem.Text = "Minimum Size";
            this.MinimumSizeToolStripMenuItem.Click += new System.EventHandler(this.MinimumSizeToolStripMenuItem_Click);
            // 
            // ToolStripSeparator5
            // 
            this.ToolStripSeparator5.Name = "ToolStripSeparator5";
            this.ToolStripSeparator5.Size = new System.Drawing.Size(178, 6);
            // 
            // RestoreOriginalSizeToolStripMenuItem
            // 
            this.RestoreOriginalSizeToolStripMenuItem.Name = "RestoreOriginalSizeToolStripMenuItem";
            this.RestoreOriginalSizeToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.RestoreOriginalSizeToolStripMenuItem.Text = "Restore Original Size";
            this.RestoreOriginalSizeToolStripMenuItem.Click += new System.EventHandler(this.RestoreOriginalSizeToolStripMenuItem_Click);
            // 
            // ToolStripSeparator4
            // 
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            this.ToolStripSeparator4.Size = new System.Drawing.Size(178, 6);
            // 
            // ResizeEnabledToolStripMenuItem
            // 
            this.ResizeEnabledToolStripMenuItem.Checked = true;
            this.ResizeEnabledToolStripMenuItem.CheckOnClick = true;
            this.ResizeEnabledToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ResizeEnabledToolStripMenuItem.Name = "ResizeEnabledToolStripMenuItem";
            this.ResizeEnabledToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.ResizeEnabledToolStripMenuItem.Text = "Resize Enabled";
            this.ResizeEnabledToolStripMenuItem.Click += new System.EventHandler(this.ResizeEnabledToolStripMenuItem_Click);
            // 
            // ToolStripSeparator7
            // 
            this.ToolStripSeparator7.Name = "ToolStripSeparator7";
            this.ToolStripSeparator7.Size = new System.Drawing.Size(178, 6);
            // 
            // DPIAutoResizeToolStripMenuItem
            // 
            this.DPIAutoResizeToolStripMenuItem.Checked = true;
            this.DPIAutoResizeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DPIAutoResizeToolStripMenuItem.Name = "DPIAutoResizeToolStripMenuItem";
            this.DPIAutoResizeToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.DPIAutoResizeToolStripMenuItem.Text = "DPI AutoResize";
            this.DPIAutoResizeToolStripMenuItem.Click += new System.EventHandler(this.DPIAutoResizeToolStripMenuItem_Click);
            // 
            // ToolbarToolStripMenuItem
            // 
            this.ToolbarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DockLeftToolStripMenuItem,
            this.DockTopToolStripMenuItem,
            this.DockToolStripMenuItem});
            this.ToolbarToolStripMenuItem.Name = "ToolbarToolStripMenuItem";
            this.ToolbarToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.ToolbarToolStripMenuItem.Text = "&Toolbar";
            // 
            // DockLeftToolStripMenuItem
            // 
            this.DockLeftToolStripMenuItem.Name = "DockLeftToolStripMenuItem";
            this.DockLeftToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.DockLeftToolStripMenuItem.Text = "Dock Top";
            this.DockLeftToolStripMenuItem.Click += new System.EventHandler(this.DockLeftToolStripMenuItem_Click);
            // 
            // DockTopToolStripMenuItem
            // 
            this.DockTopToolStripMenuItem.Name = "DockTopToolStripMenuItem";
            this.DockTopToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.DockTopToolStripMenuItem.Text = "Dock Left";
            this.DockTopToolStripMenuItem.Click += new System.EventHandler(this.DockTopToolStripMenuItem_Click);
            // 
            // DockToolStripMenuItem
            // 
            this.DockToolStripMenuItem.Name = "DockToolStripMenuItem";
            this.DockToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.DockToolStripMenuItem.Text = "Dock Right";
            this.DockToolStripMenuItem.Click += new System.EventHandler(this.DockToolStripMenuItem_Click);
            // 
            // VScrollBar1
            // 
            this.VScrollBar1.Location = new System.Drawing.Point(670, 60);
            this.VScrollBar1.Name = "VScrollBar1";
            this.NetResize1.SetResizeChildren(this.VScrollBar1, true);
            this.NetResize1.SetResizeControl(this.VScrollBar1, true);
            this.NetResize1.SetResizeFont(this.VScrollBar1, true);
            this.VScrollBar1.Size = new System.Drawing.Size(19, 365);
            this.VScrollBar1.TabIndex = 24;
            // 
            // CheckResizeList
            // 
            this.CheckResizeList.BackColor = System.Drawing.Color.Transparent;
            this.CheckResizeList.Checked = true;
            this.CheckResizeList.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckResizeList.Location = new System.Drawing.Point(256, 205);
            this.CheckResizeList.Name = "CheckResizeList";
            this.NetResize1.SetResizeChildren(this.CheckResizeList, true);
            this.NetResize1.SetResizeControl(this.CheckResizeList, true);
            this.NetResize1.SetResizeFont(this.CheckResizeList, true);
            this.CheckResizeList.Size = new System.Drawing.Size(169, 18);
            this.CheckResizeList.TabIndex = 25;
            this.CheckResizeList.Text = "Enable resize of ListView";
            this.CheckResizeList.UseVisualStyleBackColor = false;
            this.CheckResizeList.CheckedChanged += new System.EventHandler(this.CheckResizeList_CheckedChanged);
            // 
            // CheckResizeTab
            // 
            this.CheckResizeTab.BackColor = System.Drawing.Color.Transparent;
            this.CheckResizeTab.Checked = true;
            this.CheckResizeTab.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckResizeTab.Location = new System.Drawing.Point(256, 230);
            this.CheckResizeTab.Name = "CheckResizeTab";
            this.NetResize1.SetResizeChildren(this.CheckResizeTab, true);
            this.NetResize1.SetResizeControl(this.CheckResizeTab, true);
            this.NetResize1.SetResizeFont(this.CheckResizeTab, true);
            this.CheckResizeTab.Size = new System.Drawing.Size(169, 18);
            this.CheckResizeTab.TabIndex = 26;
            this.CheckResizeTab.Text = "Enable resize of TabControl";
            this.CheckResizeTab.UseVisualStyleBackColor = false;
            this.CheckResizeTab.CheckedChanged += new System.EventHandler(this.CheckResizeTab_CheckedChanged);
            // 
            // NetResize1
            // 
            this.NetResize1.ParentControl = this;
            this.NetResize1.AfterControlResize += new Softgroup.NetResize.NetResize.AfterControlResizeEventHandler(this.NetResize1_AfterControlResize);
            this.NetResize1.BeforeControlResize += new Softgroup.NetResize.NetResize.BeforeControlResizeEventHandler(this.NetResize1_BeforeControlResize);
            this.NetResize1.BeforeFormResize += new Softgroup.NetResize.NetResize.BeforeFormResizeEventHandler(this.NetResize1_BeforeFormResize);
            // 
            // FrmStandard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(699, 456);
            this.Controls.Add(this.CheckResizeTab);
            this.Controls.Add(this.CheckResizeList);
            this.Controls.Add(this.VScrollBar1);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.MenuStrip1);
            this.Controls.Add(this.ListView1);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.RichTextBox1);
            this.Controls.Add(this.NumericUpDown1);
            this.Controls.Add(this.ListBox1);
            this.Controls.Add(this.LinkLabel1);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.ComboBox1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.MenuStrip1;
            this.Name = "FrmStandard";
            this.NetResize1.SetResizeChildren(this, true);
            this.NetResize1.SetResizeControl(this, true);
            this.NetResize1.SetResizeFont(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".Net Forms Resize Sample (Standard Window)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).EndInit();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage2.ResumeLayout(false);
            this.TabPage3.ResumeLayout(false);
            this.TabPage3.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NetResize1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.ComboBox ComboBox1;
		internal System.Windows.Forms.DateTimePicker DateTimePicker1;
		internal System.Windows.Forms.LinkLabel LinkLabel1;
		internal System.Windows.Forms.ListBox ListBox1;
		internal System.Windows.Forms.NumericUpDown NumericUpDown1;
		internal System.Windows.Forms.RichTextBox RichTextBox1;
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.TextBox TextBox2;
		internal System.Windows.Forms.ListView ListView1;
		internal System.Windows.Forms.StatusStrip StatusStrip1;
		internal System.Windows.Forms.ToolStrip ToolStrip1;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.RadioButton RadioButton2;
		internal System.Windows.Forms.RadioButton RadioButton1;
		internal System.Windows.Forms.TabControl TabControl1;
		internal System.Windows.Forms.TabPage TabPage1;
		internal System.Windows.Forms.TabPage TabPage2;
		internal System.Windows.Forms.WebBrowser WebBrowser1;
		internal System.Windows.Forms.TreeView TreeView1;
		internal System.Windows.Forms.TabPage TabPage3;
		internal System.Windows.Forms.Button Button3;
		internal System.Windows.Forms.CheckedListBox CheckedListBox1;
		internal System.Windows.Forms.CheckBox CheckBox2;
		internal System.Windows.Forms.Button Button4;
		internal System.Windows.Forms.MenuStrip MenuStrip1;
		internal System.Windows.Forms.ToolStripMenuItem MenuAToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem MnuNewGrdWin;
		internal System.Windows.Forms.ToolTip ToolTip1;
		internal System.Windows.Forms.ToolStripMenuItem MnuNewMdiWin;
		internal System.Windows.Forms.VScrollBar VScrollBar1;
		internal System.Windows.Forms.ToolStripMenuItem FormToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem CenterFormToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem RestoreOriginalSizeToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem MinimizeToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem MaximizeToolStripMenuItem;
		internal System.Windows.Forms.ColumnHeader ColumnHeader5;
		internal System.Windows.Forms.ColumnHeader ColumnHeader6;
		internal System.Windows.Forms.ColumnHeader ColumnHeader7;
		internal System.Windows.Forms.ColumnHeader ColumnHeader8;
		internal System.Windows.Forms.ColumnHeader ColumnHeader9;
		internal System.Windows.Forms.ColumnHeader ColumnHeader10;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
		internal System.Windows.Forms.ToolStripMenuItem ToolbarToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem DockLeftToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem DockTopToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem DockToolStripMenuItem;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator4;
		internal System.Windows.Forms.ToolStripMenuItem MinimumSizeToolStripMenuItem;
		internal System.Windows.Forms.ToolStripButton ButNewStdWnd;
		internal System.Windows.Forms.ToolStripMenuItem MnuNewStdWin;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
		internal System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
		internal System.Windows.Forms.ToolStripButton ButNewMdiWnd;
		internal System.Windows.Forms.ToolStripButton ButNewGrdWnd;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator5;
		internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
		internal System.Windows.Forms.CheckBox CheckResizeList;
        internal System.Windows.Forms.CheckBox CheckResizeTab;
        internal System.Windows.Forms.ToolStripMenuItem EffectsToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem FadeEffectToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem ResizeEnabledToolStripMenuItem;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator7;
		internal Softgroup.NetResize.NetResize NetResize1;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator8;
		internal System.Windows.Forms.ToolStripMenuItem AddResizeEventsToListViewToolStripMenuItem;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator9;
		internal System.Windows.Forms.ToolStripMenuItem AddingControlsToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem DPIAutoResizeToolStripMenuItem;
        internal ToolStrip toolStrip2;
        internal ToolStripButton toolStripButton1;
        internal ToolStripButton toolStripButton2;
        internal ToolStripButton toolStripButton3;

	}

} //end of root namespace