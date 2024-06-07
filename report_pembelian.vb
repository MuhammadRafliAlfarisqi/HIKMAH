Public Class report_pembelian
    Private Sub report_pembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.tbl_det_beli' table. You can move, or remove it, as needed.
        Me.tbl_det_beliTableAdapter.Fill(Me.DataSet1.tbl_det_beli)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class