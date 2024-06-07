Public Class LaporanJual
    Private Sub LaporanJual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.tbl_det_jual' table. You can move, or remove it, as needed.
        Me.tbl_det_jualTableAdapter.Fill(Me.DataSet1.tbl_det_jual)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class