Public Class FrmRuntime


    Private Sub AddControlsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddControlsToolStripMenuItem.Click

        Dim oLabel1 As New System.Windows.Forms.Label
        Dim oTextBox1 As New System.Windows.Forms.TextBox
        Dim oPanel1 As New System.Windows.Forms.Panel
        Dim oLabel2 As New System.Windows.Forms.Label
        Dim oTextBox2 As New System.Windows.Forms.TextBox

        'Label1
        oLabel1.AutoEllipsis = True
        oLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        oLabel1.Location = New System.Drawing.Point(12, 37)
        oLabel1.Name = "Label1"
        oLabel1.Size = New System.Drawing.Size(100, 22)
        oLabel1.TabIndex = 1
        oLabel1.Text = "Sample Label"
        oLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        'TextBox1
        oTextBox1.Location = New System.Drawing.Point(118, 39)
        oTextBox1.Name = "TextBox1"
        oTextBox1.Size = New System.Drawing.Size(100, 20)
        oTextBox1.TabIndex = 2
        oTextBox1.Text = "Sample Text"
        'Panel1
        oPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        oPanel1.Location = New System.Drawing.Point(12, 65)
        oPanel1.Name = "Panel1"
        oPanel1.Size = New System.Drawing.Size(206, 105)
        oPanel1.TabIndex = 3
        'Label2
        oLabel2.AutoEllipsis = True
        oLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        oLabel2.Location = New System.Drawing.Point(8, 9)
        oLabel2.Name = "Label2"
        oLabel2.Size = New System.Drawing.Size(187, 22)
        oLabel2.TabIndex = 2
        oLabel2.Text = "Sample Label 2"
        oLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        'TextBox2
        oTextBox2.Location = New System.Drawing.Point(8, 43)
        oTextBox2.Multiline = True
        oTextBox2.Name = "TextBox2"
        oTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        oTextBox2.Size = New System.Drawing.Size(187, 50)
        oTextBox2.TabIndex = 3
        oTextBox2.Text = "Line 1" & ChrW(13) & ChrW(10) & "Line 2" & ChrW(13) & ChrW(10) & "Line 3" & ChrW(13) & ChrW(10)

        Me.Controls.Add(oLabel1)
        Me.Controls.Add(oTextBox1)
        oPanel1.Controls.Add(oTextBox2)
        oPanel1.Controls.Add(oLabel2)
        Me.Controls.Add(oPanel1)

        Me.AddControlsToolStripMenuItem.Enabled = False

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub RestoreFormToOriginalSizeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestoreFormToOriginalSizeToolStripMenuItem.Click
        Me.NetResize1.FormRestore()
    End Sub

    Private Sub FrmRuntime_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        MsgBox("Please click on Add Controls and then try to resize form or ... " & vbNewLine & "You can also resize form before adding controls.", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, Me.Text)
    End Sub

End Class