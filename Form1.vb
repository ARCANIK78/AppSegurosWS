Imports AppSegurosWS.WS
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim WS As New WS.WebService1SoapClient
        Dim CI As String = txtCI.Text
        Dim ds As New db.HistorialAfilacionesDataTable
        ds = WS.ConsultarHistorial(txtCI.Text)
        If ds.Rows.Count > 0 Then
            txtNombre.Text = ds.Item(0).Asegurado
            txtFechaNac.Value = ds.Item(0).fecha_nac
            txtSexo.Text = ds.Item(0).sexo
            txtEstado.Text = ds.Item(0).estado
        Else

        End If
    End Sub
End Class
