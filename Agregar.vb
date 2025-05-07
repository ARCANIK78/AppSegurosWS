Imports AppSegurosWS.WS
Public Class Agregar
    Private Sub Agregar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCIR.Text = Form1.txtCI.Text
        Try
            Dim ws As New WS.WebService1SoapClient
            Dim ds As New db.TSegurosDataTable
            ds = ws.MostrarSeguros()
            txtSegurosR.DataSource = ds
        Catch ex As Exception

        End Try
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Try
            Dim ws As New WS.WebService1SoapClient
            MsgBox(ws.RegistrarNuevoAfiliado(txtCIR.Text, txtNombreR.Text, txtPaternoR.Text, txtMaternoR.Text, txtFechaNac.Value, txtSexoR.Text, txtSegurosR.SelectedValue))
            Dim ventanafomr1 As New Form1

            Close()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

    End Sub
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Close()
    End Sub


End Class