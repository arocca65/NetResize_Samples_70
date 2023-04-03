<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStandard
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    '<System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Nodo1")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Nodo2")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Nodo3")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Nodo0", New System.Windows.Forms.TreeNode() {TreeNode10, TreeNode11, TreeNode12})
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Nodo5")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Nodo6")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Nodo7")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Nodo8")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Nodo4", New System.Windows.Forms.TreeNode() {TreeNode14, TreeNode15, TreeNode16, TreeNode17})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmStandard))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ButNewStdWnd = New System.Windows.Forms.ToolStripButton()
        Me.ButNewMdiWnd = New System.Windows.Forms.ToolStripButton()
        Me.ButNewGrdWnd = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuNewStdWin = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuNewMdiWin = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuNewGrdWin = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormWithoutControlBoxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddingControlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EffectsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FadeEffectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddResizeEventsToListViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CenterFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.MinimizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaximizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MinimumSizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.RestoreOriginalSizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ResizeEnabledToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.DPIAutoResizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolbarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DockLeftToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DockTopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.CheckResizeList = New System.Windows.Forms.CheckBox()
        Me.CheckResizeTab = New System.Windows.Forms.CheckBox()
        Me.NetResize1 = New Softgroup.NetResize.NetResize(Me.components)
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.NetResize1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Item1", "Item2", "Item3", "Item4", "Item5"})
        Me.ComboBox1.Location = New System.Drawing.Point(343, 261)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(81, 22)
        Me.ComboBox1.TabIndex = 8
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(12, 203)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(234, 20)
        Me.DateTimePicker1.TabIndex = 3
        '
        'LinkLabel1
        '
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LinkLabel1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(252, 404)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(175, 23)
        Me.LinkLabel1.TabIndex = 16
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Softgroup .Net Components"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 14
        Me.ListBox1.Location = New System.Drawing.Point(12, 322)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(234, 74)
        Me.ListBox1.Sorted = True
        Me.ListBox1.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.ListBox1, "Events")
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(252, 261)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(85, 20)
        Me.NumericUpDown1.TabIndex = 7
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 230)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.RichTextBox1.Size = New System.Drawing.Size(234, 49)
        Me.RichTextBox1.TabIndex = 5
        Me.RichTextBox1.Text = "This is a sample" & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(253, 292)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.NetResize1.SetResizeTextBoxMultiline(Me.TextBox1, False)
        Me.TextBox1.Size = New System.Drawing.Size(172, 21)
        Me.TextBox1.TabIndex = 10
        Me.TextBox1.Text = "Sample Arial"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(12, 292)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.NetResize1.SetResizeTextBoxMultiline(Me.TextBox2, False)
        Me.TextBox2.Size = New System.Drawing.Size(234, 21)
        Me.TextBox2.TabIndex = 9
        Me.TextBox2.Text = "Sample Tahoma"
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.AliceBlue
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.ListView1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.Location = New System.Drawing.Point(12, 60)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(413, 138)
        Me.ListView1.TabIndex = 2
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Control"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Left"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Top"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Width"
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Height"
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "FontSize"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 434)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.StatusStrip1.Size = New System.Drawing.Size(699, 22)
        Me.StatusStrip1.TabIndex = 17
        Me.StatusStrip1.Text = ".Net Forms Resize Demo"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(684, 17)
        Me.ToolStripStatusLabel1.Spring = True
        Me.ToolStripStatusLabel1.Text = ".Net Forms Resize Demo"
        Me.ToolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ButNewStdWnd, Me.ButNewMdiWnd, Me.ButNewGrdWnd})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(699, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ButNewStdWnd
        '
        Me.ButNewStdWnd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ButNewStdWnd.Image = CType(resources.GetObject("ButNewStdWnd.Image"), System.Drawing.Image)
        Me.ButNewStdWnd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButNewStdWnd.Name = "ButNewStdWnd"
        Me.ButNewStdWnd.Size = New System.Drawing.Size(23, 22)
        Me.ButNewStdWnd.ToolTipText = "New Standard Window"
        '
        'ButNewMdiWnd
        '
        Me.ButNewMdiWnd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ButNewMdiWnd.Image = CType(resources.GetObject("ButNewMdiWnd.Image"), System.Drawing.Image)
        Me.ButNewMdiWnd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButNewMdiWnd.Name = "ButNewMdiWnd"
        Me.ButNewMdiWnd.Size = New System.Drawing.Size(23, 22)
        Me.ButNewMdiWnd.ToolTipText = "New MDI Window"
        '
        'ButNewGrdWnd
        '
        Me.ButNewGrdWnd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ButNewGrdWnd.Image = CType(resources.GetObject("ButNewGrdWnd.Image"), System.Drawing.Image)
        Me.ButNewGrdWnd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButNewGrdWnd.Name = "ButNewGrdWnd"
        Me.ButNewGrdWnd.Size = New System.Drawing.Size(23, 22)
        Me.ButNewGrdWnd.ToolTipText = "New Data Grid Window"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(253, 322)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(172, 76)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton2.Location = New System.Drawing.Point(12, 52)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(89, 18)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(12, 27)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(89, 18)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(434, 60)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(233, 365)
        Me.TabControl1.TabIndex = 14
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.WebBrowser1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(225, 338)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(3, 3)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(219, 332)
        Me.WebBrowser1.TabIndex = 0
        Me.WebBrowser1.Url = New System.Uri("http://www.netresize.net", System.UriKind.Absolute)
        Me.WebBrowser1.WebBrowserShortcutsEnabled = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TreeView1)
        Me.TabPage2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(225, 338)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        TreeNode10.Name = "Nodo1"
        TreeNode10.Text = "Nodo1"
        TreeNode11.Name = "Nodo2"
        TreeNode11.Text = "Nodo2"
        TreeNode12.Name = "Nodo3"
        TreeNode12.Text = "Nodo3"
        TreeNode13.Name = "Nodo0"
        TreeNode13.Text = "Nodo0"
        TreeNode14.Name = "Nodo5"
        TreeNode14.Text = "Nodo5"
        TreeNode15.Name = "Nodo6"
        TreeNode15.Text = "Nodo6"
        TreeNode16.Name = "Nodo7"
        TreeNode16.Text = "Nodo7"
        TreeNode17.Name = "Nodo8"
        TreeNode17.Text = "Nodo8"
        TreeNode18.Name = "Nodo4"
        TreeNode18.Text = "Nodo4"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode13, TreeNode18})
        Me.TreeView1.Size = New System.Drawing.Size(225, 338)
        Me.TreeView1.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ToolStrip2)
        Me.TabPage3.Controls.Add(Me.CheckedListBox1)
        Me.TabPage3.Controls.Add(Me.CheckBox2)
        Me.TabPage3.Controls.Add(Me.Button3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 23)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(50)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(225, 338)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(225, 25)
        Me.ToolStrip2.TabIndex = 3
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.ToolTipText = "New Standard Window"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.ToolTipText = "New MDI Window"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.ToolTipText = "New Data Grid Window"
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"Item1", "Item2", "Item3"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(32, 182)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(154, 109)
        Me.CheckedListBox1.TabIndex = 2
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(31, 142)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(81, 18)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "CheckBox2"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(32, 70)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(161, 32)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Center Form"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 402)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(234, 21)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Clear List"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuAToolStripMenuItem, Me.EffectsToolStripMenuItem, Me.FormToolStripMenuItem, Me.ToolbarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(699, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuAToolStripMenuItem
        '
        Me.MenuAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuNewStdWin, Me.MnuNewMdiWin, Me.MnuNewGrdWin, Me.FormWithoutControlBoxToolStripMenuItem, Me.ToolStripSeparator9, Me.AddingControlsToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.MenuAToolStripMenuItem.Name = "MenuAToolStripMenuItem"
        Me.MenuAToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.MenuAToolStripMenuItem.Text = "&Show"
        '
        'MnuNewStdWin
        '
        Me.MnuNewStdWin.Name = "MnuNewStdWin"
        Me.MnuNewStdWin.Size = New System.Drawing.Size(240, 22)
        Me.MnuNewStdWin.Text = "New Standard Window"
        '
        'MnuNewMdiWin
        '
        Me.MnuNewMdiWin.Name = "MnuNewMdiWin"
        Me.MnuNewMdiWin.Size = New System.Drawing.Size(240, 22)
        Me.MnuNewMdiWin.Text = "New MDI Window"
        '
        'MnuNewGrdWin
        '
        Me.MnuNewGrdWin.Name = "MnuNewGrdWin"
        Me.MnuNewGrdWin.Size = New System.Drawing.Size(240, 22)
        Me.MnuNewGrdWin.Text = "New Data Grid Window"
        '
        'FormWithoutControlBoxToolStripMenuItem
        '
        Me.FormWithoutControlBoxToolStripMenuItem.Name = "FormWithoutControlBoxToolStripMenuItem"
        Me.FormWithoutControlBoxToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.FormWithoutControlBoxToolStripMenuItem.Text = "New Form Without Control Box"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(237, 6)
        '
        'AddingControlsToolStripMenuItem
        '
        Me.AddingControlsToolStripMenuItem.Name = "AddingControlsToolStripMenuItem"
        Me.AddingControlsToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.AddingControlsToolStripMenuItem.Text = "Adding controls at run-time"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(237, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'EffectsToolStripMenuItem
        '
        Me.EffectsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FadeEffectToolStripMenuItem, Me.ToolStripSeparator8, Me.AddResizeEventsToListViewToolStripMenuItem})
        Me.EffectsToolStripMenuItem.Name = "EffectsToolStripMenuItem"
        Me.EffectsToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.EffectsToolStripMenuItem.Text = "&Effects"
        '
        'FadeEffectToolStripMenuItem
        '
        Me.FadeEffectToolStripMenuItem.Name = "FadeEffectToolStripMenuItem"
        Me.FadeEffectToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.FadeEffectToolStripMenuItem.Text = "Fade Effect"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(225, 6)
        '
        'AddResizeEventsToListViewToolStripMenuItem
        '
        Me.AddResizeEventsToListViewToolStripMenuItem.Checked = True
        Me.AddResizeEventsToListViewToolStripMenuItem.CheckOnClick = True
        Me.AddResizeEventsToListViewToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AddResizeEventsToListViewToolStripMenuItem.Name = "AddResizeEventsToListViewToolStripMenuItem"
        Me.AddResizeEventsToListViewToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.AddResizeEventsToListViewToolStripMenuItem.Text = "Add Resize Events to ListView"
        '
        'FormToolStripMenuItem
        '
        Me.FormToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CenterFormToolStripMenuItem, Me.ToolStripSeparator3, Me.MinimizeToolStripMenuItem, Me.MaximizeToolStripMenuItem, Me.ToolStripSeparator2, Me.MinimumSizeToolStripMenuItem, Me.ToolStripSeparator5, Me.RestoreOriginalSizeToolStripMenuItem, Me.ToolStripSeparator4, Me.ResizeEnabledToolStripMenuItem, Me.ToolStripSeparator7, Me.DPIAutoResizeToolStripMenuItem})
        Me.FormToolStripMenuItem.Name = "FormToolStripMenuItem"
        Me.FormToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.FormToolStripMenuItem.Text = "&Commands"
        '
        'CenterFormToolStripMenuItem
        '
        Me.CenterFormToolStripMenuItem.Name = "CenterFormToolStripMenuItem"
        Me.CenterFormToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.CenterFormToolStripMenuItem.Text = "Center Window"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(178, 6)
        '
        'MinimizeToolStripMenuItem
        '
        Me.MinimizeToolStripMenuItem.Name = "MinimizeToolStripMenuItem"
        Me.MinimizeToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.MinimizeToolStripMenuItem.Text = "Minimize Window"
        '
        'MaximizeToolStripMenuItem
        '
        Me.MaximizeToolStripMenuItem.Name = "MaximizeToolStripMenuItem"
        Me.MaximizeToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.MaximizeToolStripMenuItem.Text = "Maximize Window"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(178, 6)
        '
        'MinimumSizeToolStripMenuItem
        '
        Me.MinimumSizeToolStripMenuItem.Checked = True
        Me.MinimumSizeToolStripMenuItem.CheckOnClick = True
        Me.MinimumSizeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MinimumSizeToolStripMenuItem.Name = "MinimumSizeToolStripMenuItem"
        Me.MinimumSizeToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.MinimumSizeToolStripMenuItem.Text = "Minimum Size"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(178, 6)
        '
        'RestoreOriginalSizeToolStripMenuItem
        '
        Me.RestoreOriginalSizeToolStripMenuItem.Name = "RestoreOriginalSizeToolStripMenuItem"
        Me.RestoreOriginalSizeToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.RestoreOriginalSizeToolStripMenuItem.Text = "Restore Original Size"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(178, 6)
        '
        'ResizeEnabledToolStripMenuItem
        '
        Me.ResizeEnabledToolStripMenuItem.Checked = True
        Me.ResizeEnabledToolStripMenuItem.CheckOnClick = True
        Me.ResizeEnabledToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ResizeEnabledToolStripMenuItem.Name = "ResizeEnabledToolStripMenuItem"
        Me.ResizeEnabledToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ResizeEnabledToolStripMenuItem.Text = "Resize Enabled"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(178, 6)
        '
        'DPIAutoResizeToolStripMenuItem
        '
        Me.DPIAutoResizeToolStripMenuItem.Checked = True
        Me.DPIAutoResizeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.DPIAutoResizeToolStripMenuItem.Name = "DPIAutoResizeToolStripMenuItem"
        Me.DPIAutoResizeToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.DPIAutoResizeToolStripMenuItem.Text = "DPI AutoResize"
        '
        'ToolbarToolStripMenuItem
        '
        Me.ToolbarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DockLeftToolStripMenuItem, Me.DockTopToolStripMenuItem, Me.DockToolStripMenuItem})
        Me.ToolbarToolStripMenuItem.Name = "ToolbarToolStripMenuItem"
        Me.ToolbarToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ToolbarToolStripMenuItem.Text = "&Toolbar"
        '
        'DockLeftToolStripMenuItem
        '
        Me.DockLeftToolStripMenuItem.Name = "DockLeftToolStripMenuItem"
        Me.DockLeftToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.DockLeftToolStripMenuItem.Text = "Dock Top"
        '
        'DockTopToolStripMenuItem
        '
        Me.DockTopToolStripMenuItem.Name = "DockTopToolStripMenuItem"
        Me.DockTopToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.DockTopToolStripMenuItem.Text = "Dock Left"
        '
        'DockToolStripMenuItem
        '
        Me.DockToolStripMenuItem.Name = "DockToolStripMenuItem"
        Me.DockToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.DockToolStripMenuItem.Text = "Dock Right"
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(670, 60)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(19, 365)
        Me.VScrollBar1.TabIndex = 15
        '
        'CheckResizeList
        '
        Me.CheckResizeList.BackColor = System.Drawing.Color.Transparent
        Me.CheckResizeList.Checked = True
        Me.CheckResizeList.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckResizeList.Location = New System.Drawing.Point(256, 205)
        Me.CheckResizeList.Name = "CheckResizeList"
        Me.CheckResizeList.Size = New System.Drawing.Size(169, 18)
        Me.CheckResizeList.TabIndex = 4
        Me.CheckResizeList.Text = "Enable resize of ListView"
        Me.CheckResizeList.UseVisualStyleBackColor = False
        '
        'CheckResizeTab
        '
        Me.CheckResizeTab.BackColor = System.Drawing.Color.Transparent
        Me.CheckResizeTab.Checked = True
        Me.CheckResizeTab.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckResizeTab.Location = New System.Drawing.Point(256, 230)
        Me.CheckResizeTab.Name = "CheckResizeTab"
        Me.CheckResizeTab.Size = New System.Drawing.Size(169, 18)
        Me.CheckResizeTab.TabIndex = 6
        Me.CheckResizeTab.Text = "Enable resize of TabControl"
        Me.CheckResizeTab.UseVisualStyleBackColor = False
        '
        'NetResize1
        '
        Me.NetResize1.ParentControl = Me
        '
        'FrmStandard
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(699, 456)
        Me.Controls.Add(Me.CheckResizeTab)
        Me.Controls.Add(Me.CheckResizeList)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmStandard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".Net Forms Resize Sample (Standard Window)"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.NetResize1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuNewGrdWin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents MnuNewMdiWin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VScrollBar1 As System.Windows.Forms.VScrollBar
    Friend WithEvents FormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CenterFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestoreOriginalSizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MinimizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaximizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolbarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DockLeftToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DockTopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MinimumSizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ButNewStdWnd As System.Windows.Forms.ToolStripButton
    Friend WithEvents MnuNewStdWin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ButNewMdiWnd As System.Windows.Forms.ToolStripButton
    Friend WithEvents ButNewGrdWnd As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents CheckResizeList As System.Windows.Forms.CheckBox
    Friend WithEvents CheckResizeTab As System.Windows.Forms.CheckBox
    Friend WithEvents EffectsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FadeEffectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResizeEnabledToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddResizeEventsToListViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddingControlsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DPIAutoResizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents FormWithoutControlBoxToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NetResize1 As NetResize.NetResize
End Class
