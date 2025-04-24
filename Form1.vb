Imports AppSegurosWS.WS
Public Class Form1
    Dim estado2 As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnOpcion.Visible = False
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
            DatosAfiliaciones.DataSource = ds
            DatosAfiliaciones.Columns.Remove("CI")
            DatosAfiliaciones.Columns.Remove("Asegurado")
            DatosAfiliaciones.Columns.Remove("Estado")
            DatosAfiliaciones.Columns.Remove("fecha_nac")
            DatosAfiliaciones.Columns.Remove("Sexo")
            btnOpcion.Visible = True
            If ds.Item(0).estado = "ALTA" Then
                btnOpcion.Text = "DAR BAJA"
                estado2 = "ALTA"
            Else
                btnOpcion.Text = "DAR ALTA"
                estado2 = "BAJA"
            End If

        Else
            txtCI.Clear()
            txtNombre.Clear()
            txtSexo.Clear()
            txtEstado.Text = "Esperando."
            txtFechaNac.Value = Now.Date
            If MsgBox("El numero del CI de la persona no esta registrasa" & vbNewLine & "Desea registrarlo?", MsgBoxStyle.YesNo, "Registrar Nuevo ASegurado") = MsgBoxResult.Yes Then
                MsgBox("Aqui crear el nuevo asegurado")
            End If
            btnOpcion.Visible = False
        End If
    End Sub

    Private Sub btnOpcion_Click(sender As Object, e As EventArgs) Handles btnOpcion.Click
        Try
            Dim ws As New WS.WebService1SoapClient
            If estado2 = "ALTA" Then
                If MsgBox("Estas seguros de dar de bajas al asegurado " & txtNombre.Text, MsgBoxStyle.YesNo, "Dar de baja al asegurado") = MsgBoxStyle.YesNo Then
                    ws.RegistrarBajas(txtCI.Text)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
