
Public Class FrmDataGrid


    Private Sub FrmDataGrid_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Sets NetResize Licenses Informations
        'With Me.NetResize1
        '    .LicenseName = "your license name or company name"
        '    .LicenseUser = "your license user name or email"
        '    .LicenseKey = "your license key"
        'End With

        LoadData()

    End Sub

    Private Sub LoadData()

        Dim Data(5) As String
        Dim Row As Integer = 0
        Dim Col As Integer = 0

        With DataGridView1
            For Row = 0 To 10
                Col = 0
                Data(Col) = "Row" & Row.ToString & " Col" & Col.ToString
                Col = 3
                Data(Col) = "Row" & Row.ToString & " Col" & Col.ToString
                .Rows.Add(Data)
            Next
        End With

    End Sub

    Private Sub NetResize1_AfterControlResize(ByVal oControl As System.Windows.Forms.Control, ByVal bCtrlResized As Boolean, ByVal bFontResized As Boolean)
        Me.DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
    End Sub

End Class