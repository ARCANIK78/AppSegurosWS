Imports AppSegurosWS.WS
Public Class Form1
    Dim estado2 As String
    Private Sub MostrarHistorial()
        Dim WS As New WS.WebService1SoapClient
        Dim ds As New db.HistorialAfilacionesDataTable
        Dim CI As String = txtCI.Text
        ds = WS.ConsultarHistorial(txtCI.Text)
        txtEstado.Text = ds.Item(0).estado
        DatosAfiliaciones.DataSource = ds
        DatosAfiliaciones.Columns.Remove("CI")
        DatosAfiliaciones.Columns.Remove("Asegurado")
        DatosAfiliaciones.Columns.Remove("Estado")
        DatosAfiliaciones.Columns.Remove("fecha_nac")
        DatosAfiliaciones.Columns.Remove("Sexo")
        BtnOpcion.Visible = True
        If ds.Item(0).estado = "ALTA" Then
            BtnOpcion.Text = "DAR BAJA"
            estado2 = "ALTA"
        Else
            BtnOpcion.Text = "DAR ALTA"
            estado2 = "BAJA"
        End If
    End Sub
    Private Sub mostrarDatos()
        Dim ws As New WS.WebService1SoapClient
        Dim ds As New db.HistorialAfilacionesDataTable
        Dim CI As String = txtCI.Text
        ds = ws.ConsultarHistorial(txtCI.Text)
        If ds.Rows.Count > 0 Then
            txtNombre.Text = ds.Item(0).Asegurado
            txtFechaNac.Value = ds.Item(0).fecha_nac
            txtSexo.Text = ds.Item(0).sexo
            txtEstado.Text = ds.Item(0).estado
            DatosAfiliaciones.DataSource = ds
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnOpcion.Visible = False
    End Sub
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
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
            BtnOpcion.Visible = True
            If ds.Item(0).estado = "ALTA" Then
                BtnOpcion.Text = "DAR BAJA"
                estado2 = "ALTA"
            Else
                BtnOpcion.Text = "DAR ALTA"
                estado2 = "BAJA"
            End If

        Else
            ' txtCI.Clear()
            txtNombre.Clear()
            txtSexo.Clear()
            txtEstado.Text = "Esperando."
            txtFechaNac.Value = Date.Now
            If MsgBox("El numero del CI de la persona no esta registrasa" & vbNewLine & "Desea registrarlo?", MsgBoxStyle.YesNo, "Registrar Nuevo ASegurado") = MsgBoxResult.Yes Then
                Dim f As New Agregar
                f.txtCIR.Text = txtCI.Text
                f.ShowDialog()
                mostrarDatos()
                MostrarHistorial()
            End If
            BtnOpcion.Visible = False
        End If
    End Sub

    Private Sub BtnOpcion_Click(sender As Object, e As EventArgs) Handles BtnOpcion.Click
        Try
            Dim ws As New WS.WebService1SoapClient
            If estado2 = "ALTA" Then
                If MsgBox("Estas seguros de dar de bajas al asegurado " & txtNombre.Text, MsgBoxStyle.YesNo, "Dar de baja al asegurado") = MsgBoxResult.Yes Then
                    MsgBox(ws.RegistrarBajas(txtCI.Text))
                    MostrarHistorial()
                End If
            Else
                estado2 = "BAJA"
                Mensaje.ShowDialog()
                Dim seleccionado As String = Mensaje.IdSeleccionado
                If seleccionado <> "" AndAlso seleccionado <> "0" Then
                    MsgBox(ws.DarAltas(txtCI.Text, seleccionado))
                    MostrarHistorial()
                End If
            End If
        Catch ex As Exception
            ' Manejo de excepciones opcional
        End Try
    End Sub
End Class
