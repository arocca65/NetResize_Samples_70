Imports System.Windows.Forms

Public Class FrmMDI


    Private Sub NewWindowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewWindowToolStripMenuItem.Click
        Dim oChild As New FrmStandard
        oChild.MdiParent = Me
        oChild.Show()
    End Sub

    Private Sub NewWindowBToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewWindowBToolStripMenuItem.Click
        Dim oChild As New FrmDataGrid
        oChild.MdiParent = Me
        oChild.Show()
    End Sub

End Class

