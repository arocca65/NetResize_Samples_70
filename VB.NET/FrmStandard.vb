Imports Softgroup.NetResize

Public Class FrmStandard

    Private Sub ButNewGrdWnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButNewGrdWnd.Click

        Dim nForm As New FrmDataGrid
        nForm.Show()

    End Sub

    Private Sub ButNewMdiWnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButNewMdiWnd.Click

        Dim nForm As New FrmMDI
        nForm.Show()

    End Sub


    Private Sub ButNewStdWnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButNewStdWnd.Click
        Dim nForm As New FrmStandard
        nForm.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.NetResize1.FormCenter()
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.ListView1.Items.Clear()
        Me.ListBox1.Items.Clear()
    End Sub

    Private Sub CenterFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CenterFormToolStripMenuItem.Click
        Me.NetResize1.FormCenter()
    End Sub

    Private Sub CheckResizeList_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckResizeList.CheckedChanged

        Me.NetResize1.ExcludedResize(Me.ListView1, NetResize.NetResize.ExcludedResizeEnum.erAll) = Not Me.CheckResizeList.Checked
        Me.NetResize1.Refresh()

    End Sub

    Private Sub CheckResizeTab_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckResizeTab.CheckedChanged

        Me.NetResize1.ExcludedResize(Me.TabControl1, NetResize.NetResize.ExcludedResizeEnum.erAll) = Not Me.CheckResizeTab.Checked
        Me.NetResize1.Refresh()

    End Sub

    Private Sub DockLeftToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DockLeftToolStripMenuItem.Click
        Me.ToolStrip1.Dock = DockStyle.Top
        Me.ToolStrip2.Dock = DockStyle.Top
        Me.NetResize1.Refresh()
    End Sub

    Private Sub DockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DockToolStripMenuItem.Click
        Me.ToolStrip1.Dock = DockStyle.Right
        Me.ToolStrip2.Dock = DockStyle.Right
        Me.NetResize1.Refresh()
    End Sub

    Private Sub DockTopToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DockTopToolStripMenuItem.Click
        Me.ToolStrip1.Dock = DockStyle.Left
        Me.ToolStrip2.Dock = DockStyle.Left
        Me.NetResize1.Refresh()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        Exit Sub
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'You must enter valid Licensing informations (uncomment code below)
        'Softgroup.NetResize.License.LicenseName = "your license name or company name"
        'Softgroup.NetResize.License.LicenseUser = "your license user name or email"
        'Softgroup.NetResize.License.LicenseKey = "your license key "

        'Custom Resize Properties  (Grid Column With)
        Me.NetResize1.AddControlPropertyWidth(Me.ListView1, "Columns(0).Width")
        'Code below disable resize the form to a size smaller than design-time size (stretch  and shrink)
        Me.NetResize1.MinimumSize = New System.Drawing.Size(Me.NetResize1.OriginalFormWidth, Me.NetResize1.OriginalFormHeight)
        'Reposizione and resize form
        'Me.Location = New Point(My.Computer.Screen.WorkingArea.Left, My.Computer.Screen.WorkingArea.Top)
        'Me.Size = New Size(My.Computer.Screen.WorkingArea.Width, My.Computer.Screen.WorkingArea.Height)

    End Sub


    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim oProcess As New System.Diagnostics.Process
        oProcess.StartInfo.FileName = "http://www.soft-group.it"
        oProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        oProcess.Start()
    End Sub

    Private Sub MaximizeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaximizeToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub MinimizeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MinimizeToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub MinimumSizeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MinimumSizeToolStripMenuItem.Click

        If MinimumSizeToolStripMenuItem.Checked Then
            Me.NetResize1.MinimumSize = New System.Drawing.Size(Me.NetResize1.OriginalFormWidth, Me.NetResize1.OriginalFormHeight)
        Else
            Me.NetResize1.MinimumSize = New System.Drawing.Size(0, 0)
        End If

    End Sub

    Private Sub MnuNewGrdWin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuNewGrdWin.Click

        Dim nForm As New FrmDataGrid
        nForm.Show()

    End Sub

    Private Sub MnuNewMdiWin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuNewMdiWin.Click

        Dim nForm As New FrmMDI
        nForm.Show()

    End Sub

    Private Sub MnuNewStdWin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuNewStdWin.Click

        Using nForm As New FrmStandard
            nForm.ShowDialog(Me)
        End Using

    End Sub

    Private Sub RestoreOriginalSizeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestoreOriginalSizeToolStripMenuItem.Click
        Me.NetResize1.FormRestore()
    End Sub

    Private Sub FadeEffectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FadeEffectToolStripMenuItem.Click

        Me.NetResize1.FormFadeOut()
        Me.NetResize1.FormFadeIn()

    End Sub

    Private Sub ResizeEnabledToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResizeEnabledToolStripMenuItem.Click
        Me.NetResize1.Enabled = ResizeEnabledToolStripMenuItem.Checked
    End Sub

    Private Sub AddingControlsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddingControlsToolStripMenuItem.Click
        Dim fRuntime As New FrmRuntime
        fRuntime.Show(Me)
    End Sub

    Private Sub DPIAutoResizeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DPIAutoResizeToolStripMenuItem.Click
        NetResize1.DPIAutoResize = Not NetResize1.DPIAutoResize
        DPIAutoResizeToolStripMenuItem.Checked = NetResize1.DPIAutoResize
        MsgBox("This form will be designed at 96 DPI resolution. To see DPIAutoResize property in action you must change system DPI resolution and restart this sample application.", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, Me.Text)
    End Sub

    Private Sub FormWithoutControlBoxToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormWithoutControlBoxToolStripMenuItem.Click
        Using F As New FrmNoControlBox
            F.ShowDialog(Me)
        End Using
    End Sub


    Private Sub NetResize1_BeforeControlResize(sender As Object, e As BeforeControlResizeEventArgs) Handles NetResize1.BeforeControlResize
        If Me.AddResizeEventsToListViewToolStripMenuItem.Checked Then
            Dim oItem As ListViewItem
            oItem = Me.ListView1.Items.Add(TypeName(e.Control) & " (" & e.Control.Name & ")")
            oItem.SubItems.Add(e.Control.Left.ToString)
            oItem.SubItems.Add(e.Control.Top.ToString)
            oItem.SubItems.Add(e.Control.Width.ToString)
            oItem.SubItems.Add(e.Control.Height.ToString)
            If Not e.Control.Font Is Nothing Then
                oItem.SubItems.Add(e.Control.Font.Size.ToString)
            End If
        End If
    End Sub

    Private Sub NetResize1_AfterControlResize(sender As Object, e As AfterControlResizeEventArgs) Handles NetResize1.AfterControlResize
        If Me.AddResizeEventsToListViewToolStripMenuItem.Checked Then
            Me.ListBox1.Items.Add(e.Control.Name & " " & e.CtrlResize.ToString & " " & e.FontResize.ToString)
        End If
    End Sub

End Class

